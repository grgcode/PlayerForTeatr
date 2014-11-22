namespace PlayerForTeatr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            this.listBoxPlayList = new System.Windows.Forms.CheckedListBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelPlay = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonClearError = new System.Windows.Forms.Button();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClearError);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxError);
            this.splitContainer1.Size = new System.Drawing.Size(565, 624);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonHelp);
            this.splitContainer2.Panel1.Controls.Add(this.checkBoxFast);
            this.splitContainer2.Panel1.Controls.Add(this.listBoxPlayList);
            this.splitContainer2.Panel1.Controls.Add(this.buttonStop);
            this.splitContainer2.Panel1.Controls.Add(this.buttonPlay);
            this.splitContainer2.Panel1.Controls.Add(this.buttonNext);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFolder);
            this.splitContainer2.Panel1.Controls.Add(this.buttonBrowse);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelPlay);
            this.splitContainer2.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer2.Size = new System.Drawing.Size(545, 548);
            this.splitContainer2.SplitterDistance = 413;
            this.splitContainer2.TabIndex = 2;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(517, 0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(28, 23);
            this.buttonHelp.TabIndex = 10;
            this.buttonHelp.Text = "?";
            this.toolTip1.SetToolTip(this.buttonHelp, "Show Help");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFast.Location = new System.Drawing.Point(376, 389);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(121, 20);
            this.checkBoxFast.TabIndex = 9;
            this.checkBoxFast.Text = "Fast Navigation";
            this.toolTip1.SetToolTip(this.checkBoxFast, "Turn On/Off Fast Navigation with Arrow Keys");
            this.checkBoxFast.UseVisualStyleBackColor = true;
            this.checkBoxFast.CheckedChanged += new System.EventHandler(this.checkBoxFast_CheckedChanged);
            // 
            // listBoxPlayList
            // 
            this.listBoxPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayList.FormattingEnabled = true;
            this.listBoxPlayList.IntegralHeight = false;
            this.listBoxPlayList.Location = new System.Drawing.Point(4, 28);
            this.listBoxPlayList.Name = "listBoxPlayList";
            this.listBoxPlayList.Size = new System.Drawing.Size(538, 355);
            this.listBoxPlayList.Sorted = true;
            this.listBoxPlayList.TabIndex = 8;
            this.toolTip1.SetToolTip(this.listBoxPlayList, "Play List");
            this.listBoxPlayList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBoxPlayList_ItemCheck);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Location = new System.Drawing.Point(248, 388);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(116, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "&Stop";
            this.toolTip1.SetToolTip(this.buttonStop, "Stop Playing Song");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Location = new System.Drawing.Point(126, 388);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(116, 23);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Pl&ay";
            this.toolTip1.SetToolTip(this.buttonPlay, "Play Song Selected on Play List from  Start");
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNext.Location = new System.Drawing.Point(4, 388);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(116, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Select Ne&xt";
            this.toolTip1.SetToolTip(this.buttonNext, "Select Next Song from Play List");
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(3, 2);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(442, 20);
            this.textBoxFolder.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxFolder, "Play List location");
            this.textBoxFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFolder_KeyDown);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(451, 0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(61, 23);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.buttonBrowse, "Browse for Folder with Play List");
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Black;
            this.labelPlay.ForeColor = System.Drawing.Color.White;
            this.labelPlay.Location = new System.Drawing.Point(-1, 0);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(0, 13);
            this.labelPlay.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(10);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Padding = new System.Windows.Forms.Padding(10);
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(545, 131);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.TabStop = false;
            this.toolTip1.SetToolTip(this.axWindowsMediaPlayer1, "Media Player ");
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // buttonClearError
            // 
            this.buttonClearError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearError.BackgroundImage")));
            this.buttonClearError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClearError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearError.Location = new System.Drawing.Point(540, 3);
            this.buttonClearError.Name = "buttonClearError";
            this.buttonClearError.Padding = new System.Windows.Forms.Padding(5);
            this.buttonClearError.Size = new System.Drawing.Size(22, 21);
            this.buttonClearError.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonClearError, "Clear Error History");
            this.buttonClearError.UseVisualStyleBackColor = true;
            this.buttonClearError.Click += new System.EventHandler(this.buttonClearError_Click);
            // 
            // textBoxError
            // 
            this.textBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxError.Location = new System.Drawing.Point(9, 4);
            this.textBoxError.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxError.Size = new System.Drawing.Size(527, 39);
            this.textBoxError.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxError, "Error History");
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 624);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Player for Teatr";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonClearError;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.CheckedListBox listBoxPlayList;
        private System.Windows.Forms.CheckBox checkBoxFast;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}

