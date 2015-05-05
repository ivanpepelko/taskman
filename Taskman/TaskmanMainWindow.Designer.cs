namespace Taskman {
    partial class TaskmanMainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.processesListView = new System.Windows.Forms.ListView();
            this.processName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.threads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAllProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endSelectedProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processesListView
            // 
            this.processesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processName,
            this.pid,
            this.memoryUsage,
            this.threads});
            this.processesListView.Location = new System.Drawing.Point(12, 27);
            this.processesListView.MultiSelect = false;
            this.processesListView.Name = "processesListView";
            this.processesListView.Size = new System.Drawing.Size(360, 523);
            this.processesListView.TabIndex = 4;
            this.processesListView.UseCompatibleStateImageBehavior = false;
            this.processesListView.View = System.Windows.Forms.View.Details;
            // 
            // processName
            // 
            this.processName.Text = "Process Name";
            this.processName.Width = 120;
            // 
            // pid
            // 
            this.pid.Text = "PID";
            this.pid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memoryUsage
            // 
            this.memoryUsage.Text = "Memory Usage";
            this.memoryUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.memoryUsage.Width = 90;
            // 
            // threads
            // 
            this.threads.Text = "Threads";
            this.threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Applications|*.exe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.loadAllProcessesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runProcessToolStripMenuItem,
            this.processInfoToolStripMenuItem,
            this.endProcessToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runProcessToolStripMenuItem
            // 
            this.runProcessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runProcessToolStripMenuItem.Name = "runProcessToolStripMenuItem";
            this.runProcessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runProcessToolStripMenuItem.Text = "Run process";
            this.runProcessToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // processInfoToolStripMenuItem
            // 
            this.processInfoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.processInfoToolStripMenuItem.Name = "processInfoToolStripMenuItem";
            this.processInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processInfoToolStripMenuItem.Text = "Process Info";
            this.processInfoToolStripMenuItem.Click += new System.EventHandler(this.processInfoToolStripMenuItem_Click);
            // 
            // endProcessToolStripMenuItem
            // 
            this.endProcessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.endProcessToolStripMenuItem.Name = "endProcessToolStripMenuItem";
            this.endProcessToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endProcessToolStripMenuItem.Text = "End process";
            this.endProcessToolStripMenuItem.Click += new System.EventHandler(this.endProcessToolStripMenuItem_Click);
            // 
            // loadAllProcessesToolStripMenuItem
            // 
            this.loadAllProcessesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProcessesToolStripMenuItem,
            this.endSelectedProcessToolStripMenuItem});
            this.loadAllProcessesToolStripMenuItem.Name = "loadAllProcessesToolStripMenuItem";
            this.loadAllProcessesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.loadAllProcessesToolStripMenuItem.Text = "Process list";
            // 
            // loadProcessesToolStripMenuItem
            // 
            this.loadProcessesToolStripMenuItem.Name = "loadProcessesToolStripMenuItem";
            this.loadProcessesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadProcessesToolStripMenuItem.Text = "Load processes";
            this.loadProcessesToolStripMenuItem.Click += new System.EventHandler(this.loadProcessesToolStripMenuItem_Click);
            // 
            // endSelectedProcessToolStripMenuItem
            // 
            this.endSelectedProcessToolStripMenuItem.Name = "endSelectedProcessToolStripMenuItem";
            this.endSelectedProcessToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.endSelectedProcessToolStripMenuItem.Text = "End selected process";
            this.endSelectedProcessToolStripMenuItem.Click += new System.EventHandler(this.endSelectedProcessToolStripMenuItem_Click);
            // 
            // TaskmanMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 562);
            this.Controls.Add(this.processesListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "TaskmanMainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taskman";
            this.Resize += new System.EventHandler(this.TaskmanMainWindow_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView processesListView;
        private System.Windows.Forms.ColumnHeader processName;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.ColumnHeader memoryUsage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processInfoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader threads;
        private System.Windows.Forms.ToolStripMenuItem loadProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endSelectedProcessToolStripMenuItem;

    }
}

