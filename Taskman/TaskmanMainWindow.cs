using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Taskman {
    public partial class TaskmanMainWindow : Form {

        Process StartedProcess;

        public TaskmanMainWindow() {
            InitializeComponent();
        }

        public ListViewItem[] getProcessesListItems() {
            Process[] procs = Process.GetProcesses();
            List<ListViewItem> processes = new List<ListViewItem>();

            foreach (Process proc in procs) {
                processes.Add(new ListViewItem(new string[] {
                    proc.ProcessName, proc.Id.ToString(), string.Format("{0:n0} K", (double)proc.WorkingSet64 / 1000)
                    }));
            }

            return processes.ToArray();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                StartedProcess = Process.Start(openFileDialog1.FileName);
            }
        }

        private void endProcessToolStripMenuItem_Click(object sender, EventArgs e) {
            if (StartedProcess != null && !StartedProcess.HasExited) {
                StartedProcess.Kill();
                MessageBox.Show("Process " + StartedProcess.StartInfo.FileName + " closed.");
            } else
                MessageBox.Show("There is currently no process started with this program.");
        }

        private void processInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (StartedProcess != null && !StartedProcess.HasExited) {
                MessageBox.Show(string.Format(
                    "Process name: {0}\nPID: {1}\nMemory usage: {2}\nThreads: {3}",
                    StartedProcess.ProcessName,
                    StartedProcess.Id,
                    string.Format("{0:n0} K", (double)StartedProcess.WorkingSet64 / 1024),
                    StartedProcess.Threads.Count
                    ));
            } else
                MessageBox.Show("There is currently no process started with this program.");
        }

        private void loadProcessesToolStripMenuItem_Click(object sender, EventArgs e) {
            loadProcesses();
        }

        private void endSelectedProcessToolStripMenuItem_Click(object sender, EventArgs e) {
            int pid = Convert.ToInt32(processesListView.SelectedItems[0].SubItems[1].Text);
            Process toKill = Process.GetProcessById(pid);
            if (toKill != null && !toKill.HasExited) {
                toKill.Kill();
                MessageBox.Show("Process " + toKill.ProcessName + " closed.");
                loadProcesses();
            }
        }

        void loadProcesses() {
            Process[] procs = Process.GetProcesses();
            procs.OrderBy(p => p.ProcessName);

            List<ListViewItem> processes = new List<ListViewItem>();

            foreach (Process proc in procs.OrderBy(p => p.ProcessName)) {
                processes.Add(new ListViewItem(new string[] {
                    proc.ProcessName, proc.Id.ToString(), string.Format("{0:n0} K", (double)proc.WorkingSet64 / 1024), proc.Threads.Count.ToString()
                    }));
            }

            processesListView.Items.Clear();
            processesListView.Items.AddRange(processes.ToArray());
        }

        private void TaskmanMainWindow_Resize(object sender, EventArgs e) {
            processesListView.Width = Width - 40;
        }
    }

}
