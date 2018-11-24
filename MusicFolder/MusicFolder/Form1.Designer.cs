namespace MusicFolder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnSelectWinampPalylist = new System.Windows.Forms.Button();
            this.txtPathFileList = new System.Windows.Forms.TextBox();
            this.chkPreserveFileOrder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRootFolder = new System.Windows.Forms.TextBox();
            this.fileList = new System.Windows.Forms.OpenFileDialog();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtSubFolder = new System.Windows.Forms.TextBox();
            this.chkCreateSubFolder = new System.Windows.Forms.CheckBox();
            this.btnOpenWinampPalylist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Root Folder";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(125, 251);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFiles.Size = new System.Drawing.Size(645, 316);
            this.lstFiles.TabIndex = 1;
            // 
            // btnSelectWinampPalylist
            // 
            this.btnSelectWinampPalylist.Location = new System.Drawing.Point(502, 40);
            this.btnSelectWinampPalylist.Name = "btnSelectWinampPalylist";
            this.btnSelectWinampPalylist.Size = new System.Drawing.Size(125, 23);
            this.btnSelectWinampPalylist.TabIndex = 2;
            this.btnSelectWinampPalylist.Text = "Select Winamp Playlist";
            this.btnSelectWinampPalylist.UseVisualStyleBackColor = true;
            this.btnSelectWinampPalylist.Click += new System.EventHandler(this.btnSelectWinampPalylist_Click);
            // 
            // txtPathFileList
            // 
            this.txtPathFileList.Location = new System.Drawing.Point(113, 42);
            this.txtPathFileList.Name = "txtPathFileList";
            this.txtPathFileList.Size = new System.Drawing.Size(383, 20);
            this.txtPathFileList.TabIndex = 4;
            // 
            // chkPreserveFileOrder
            // 
            this.chkPreserveFileOrder.AutoSize = true;
            this.chkPreserveFileOrder.Checked = true;
            this.chkPreserveFileOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreserveFileOrder.Location = new System.Drawing.Point(113, 211);
            this.chkPreserveFileOrder.Name = "chkPreserveFileOrder";
            this.chkPreserveFileOrder.Size = new System.Drawing.Size(222, 17);
            this.chkPreserveFileOrder.TabIndex = 5;
            this.chkPreserveFileOrder.Text = "Preserve file order adding trailing numbers";
            this.chkPreserveFileOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Path File List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub folder";
            // 
            // txtRootFolder
            // 
            this.txtRootFolder.Location = new System.Drawing.Point(113, 85);
            this.txtRootFolder.Name = "txtRootFolder";
            this.txtRootFolder.Size = new System.Drawing.Size(383, 20);
            this.txtRootFolder.TabIndex = 4;
            this.txtRootFolder.Text = "D:";
            this.txtRootFolder.Leave += new System.EventHandler(this.txtRootFolder_Leave);
            // 
            // fileList
            // 
            this.fileList.DefaultExt = "m3u";
            this.fileList.Filter = "Winamp Playlist|*.m3u";
            this.fileList.InitialDirectory = "D:\\BKPED\\Music";
            this.fileList.ShowReadOnly = true;
            this.fileList.Title = "Open Winamp Playlist";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(113, 128);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(383, 20);
            this.txtOutputFolder.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(37, 279);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(64, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtSubFolder
            // 
            this.txtSubFolder.Location = new System.Drawing.Point(113, 171);
            this.txtSubFolder.Name = "txtSubFolder";
            this.txtSubFolder.Size = new System.Drawing.Size(247, 20);
            this.txtSubFolder.TabIndex = 4;
            this.txtSubFolder.Leave += new System.EventHandler(this.txtSubFolder_Leave);
            // 
            // chkCreateSubFolder
            // 
            this.chkCreateSubFolder.AutoSize = true;
            this.chkCreateSubFolder.Checked = true;
            this.chkCreateSubFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateSubFolder.Location = new System.Drawing.Point(385, 173);
            this.chkCreateSubFolder.Name = "chkCreateSubFolder";
            this.chkCreateSubFolder.Size = new System.Drawing.Size(111, 17);
            this.chkCreateSubFolder.TabIndex = 5;
            this.chkCreateSubFolder.Text = "Create Sub-Folder";
            this.chkCreateSubFolder.UseVisualStyleBackColor = true;
            // 
            // btnOpenWinampPalylist
            // 
            this.btnOpenWinampPalylist.Location = new System.Drawing.Point(633, 40);
            this.btnOpenWinampPalylist.Name = "btnOpenWinampPalylist";
            this.btnOpenWinampPalylist.Size = new System.Drawing.Size(125, 23);
            this.btnOpenWinampPalylist.TabIndex = 2;
            this.btnOpenWinampPalylist.Text = "Open Winamp Playlist";
            this.btnOpenWinampPalylist.UseVisualStyleBackColor = true;
            this.btnOpenWinampPalylist.Click += new System.EventHandler(this.btnOpenWinampPalylist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Playlist";
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBar.Location = new System.Drawing.Point(0, 576);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(800, 23);
            this.pBar.TabIndex = 8;
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(502, 126);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(125, 23);
            this.btnOutputFolder.TabIndex = 9;
            this.btnOutputFolder.Text = "Select Output Folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btnOutputFolder);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkCreateSubFolder);
            this.Controls.Add(this.chkPreserveFileOrder);
            this.Controls.Add(this.txtRootFolder);
            this.Controls.Add(this.txtSubFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.txtPathFileList);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnOpenWinampPalylist);
            this.Controls.Add(this.btnSelectWinampPalylist);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Music Folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnSelectWinampPalylist;
        private System.Windows.Forms.TextBox txtPathFileList;
        private System.Windows.Forms.CheckBox chkPreserveFileOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRootFolder;
        private System.Windows.Forms.OpenFileDialog fileList;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtSubFolder;
        private System.Windows.Forms.CheckBox chkCreateSubFolder;
        private System.Windows.Forms.Button btnOpenWinampPalylist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

