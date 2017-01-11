namespace Compression
{
    partial class MainForm
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
            this.btnCompress = new System.Windows.Forms.Button();
            this.lblCompressOutput = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCompress = new System.Windows.Forms.TabPage();
            this.tabDecompress = new System.Windows.Forms.TabPage();
            this.lblDecompress = new System.Windows.Forms.Label();
            this.openFileToCompress = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDest = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileToDecompress = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenCompress = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnDestFolder = new System.Windows.Forms.Button();
            this.lblDestFolder = new System.Windows.Forms.Label();
            this.lblDecompressFolder = new System.Windows.Forms.Label();
            this.btnDestFolderDecompress = new System.Windows.Forms.Button();
            this.lblFileDecompress = new System.Windows.Forms.Label();
            this.btnFileDecompress = new System.Windows.Forms.Button();
            this.btnDecompress = new System.Windows.Forms.Button();
            this.folderBrowserDecompress = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabCompress.SuspendLayout();
            this.tabDecompress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompress
            // 
            this.btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompress.Location = new System.Drawing.Point(6, 61);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(562, 29);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // lblCompressOutput
            // 
            this.lblCompressOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompressOutput.BackColor = System.Drawing.Color.Black;
            this.lblCompressOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompressOutput.Location = new System.Drawing.Point(6, 93);
            this.lblCompressOutput.Name = "lblCompressOutput";
            this.lblCompressOutput.Padding = new System.Windows.Forms.Padding(5);
            this.lblCompressOutput.Size = new System.Drawing.Size(562, 221);
            this.lblCompressOutput.TabIndex = 3;
            this.lblCompressOutput.Text = "compression output";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabCompress);
            this.tabControl.Controls.Add(this.tabDecompress);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(582, 346);
            this.tabControl.TabIndex = 4;
            // 
            // tabCompress
            // 
            this.tabCompress.Controls.Add(this.lblDestFolder);
            this.tabCompress.Controls.Add(this.btnDestFolder);
            this.tabCompress.Controls.Add(this.lblFileName);
            this.tabCompress.Controls.Add(this.btnOpenCompress);
            this.tabCompress.Controls.Add(this.lblCompressOutput);
            this.tabCompress.Controls.Add(this.btnCompress);
            this.tabCompress.Location = new System.Drawing.Point(4, 22);
            this.tabCompress.Name = "tabCompress";
            this.tabCompress.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompress.Size = new System.Drawing.Size(574, 320);
            this.tabCompress.TabIndex = 0;
            this.tabCompress.Text = "Compress";
            this.tabCompress.UseVisualStyleBackColor = true;
            // 
            // tabDecompress
            // 
            this.tabDecompress.Controls.Add(this.btnDecompress);
            this.tabDecompress.Controls.Add(this.lblDecompressFolder);
            this.tabDecompress.Controls.Add(this.btnDestFolderDecompress);
            this.tabDecompress.Controls.Add(this.lblFileDecompress);
            this.tabDecompress.Controls.Add(this.btnFileDecompress);
            this.tabDecompress.Controls.Add(this.lblDecompress);
            this.tabDecompress.Location = new System.Drawing.Point(4, 22);
            this.tabDecompress.Name = "tabDecompress";
            this.tabDecompress.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecompress.Size = new System.Drawing.Size(574, 320);
            this.tabDecompress.TabIndex = 1;
            this.tabDecompress.Text = "Decompress";
            this.tabDecompress.UseVisualStyleBackColor = true;
            // 
            // lblDecompress
            // 
            this.lblDecompress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecompress.BackColor = System.Drawing.Color.Black;
            this.lblDecompress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDecompress.Location = new System.Drawing.Point(6, 93);
            this.lblDecompress.Name = "lblDecompress";
            this.lblDecompress.Padding = new System.Windows.Forms.Padding(5);
            this.lblDecompress.Size = new System.Drawing.Size(562, 221);
            this.lblDecompress.TabIndex = 4;
            this.lblDecompress.Text = "Decompression output";
            // 
            // openFileToDecompress
            // 
            this.openFileToDecompress.Filter = "Compressed file | *.ghcf";
            // 
            // btnOpenCompress
            // 
            this.btnOpenCompress.Location = new System.Drawing.Point(6, 6);
            this.btnOpenCompress.Name = "btnOpenCompress";
            this.btnOpenCompress.Size = new System.Drawing.Size(116, 23);
            this.btnOpenCompress.TabIndex = 1;
            this.btnOpenCompress.Text = "Choose File";
            this.btnOpenCompress.UseVisualStyleBackColor = true;
            this.btnOpenCompress.Click += new System.EventHandler(this.btnOpenCompress_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Location = new System.Drawing.Point(128, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(437, 23);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "Select a file to compress...";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDestFolder
            // 
            this.btnDestFolder.Location = new System.Drawing.Point(6, 32);
            this.btnDestFolder.Name = "btnDestFolder";
            this.btnDestFolder.Size = new System.Drawing.Size(116, 23);
            this.btnDestFolder.TabIndex = 5;
            this.btnDestFolder.Text = "Destination folder";
            this.btnDestFolder.UseVisualStyleBackColor = true;
            this.btnDestFolder.Click += new System.EventHandler(this.btnDestFolder_Click);
            // 
            // lblDestFolder
            // 
            this.lblDestFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestFolder.Location = new System.Drawing.Point(128, 32);
            this.lblDestFolder.Name = "lblDestFolder";
            this.lblDestFolder.Size = new System.Drawing.Size(437, 23);
            this.lblDestFolder.TabIndex = 6;
            this.lblDestFolder.Text = "Choose a destination folder for the compressed file...";
            this.lblDestFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecompressFolder
            // 
            this.lblDecompressFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDecompressFolder.Location = new System.Drawing.Point(128, 32);
            this.lblDecompressFolder.Name = "lblDecompressFolder";
            this.lblDecompressFolder.Size = new System.Drawing.Size(437, 23);
            this.lblDecompressFolder.TabIndex = 10;
            this.lblDecompressFolder.Text = "Choose a destination folder for the decompressed file...";
            this.lblDecompressFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDecompressFolder.Visible = false;
            // 
            // btnDestFolderDecompress
            // 
            this.btnDestFolderDecompress.Location = new System.Drawing.Point(6, 32);
            this.btnDestFolderDecompress.Name = "btnDestFolderDecompress";
            this.btnDestFolderDecompress.Size = new System.Drawing.Size(116, 23);
            this.btnDestFolderDecompress.TabIndex = 9;
            this.btnDestFolderDecompress.Text = "Destination folder";
            this.btnDestFolderDecompress.UseVisualStyleBackColor = true;
            this.btnDestFolderDecompress.Visible = false;
            this.btnDestFolderDecompress.Click += new System.EventHandler(this.btnDestFolderDecompress_Click);
            // 
            // lblFileDecompress
            // 
            this.lblFileDecompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileDecompress.Location = new System.Drawing.Point(128, 6);
            this.lblFileDecompress.Name = "lblFileDecompress";
            this.lblFileDecompress.Size = new System.Drawing.Size(437, 23);
            this.lblFileDecompress.TabIndex = 8;
            this.lblFileDecompress.Text = "Select a file to compress...";
            this.lblFileDecompress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFileDecompress
            // 
            this.btnFileDecompress.Location = new System.Drawing.Point(6, 6);
            this.btnFileDecompress.Name = "btnFileDecompress";
            this.btnFileDecompress.Size = new System.Drawing.Size(116, 23);
            this.btnFileDecompress.TabIndex = 7;
            this.btnFileDecompress.Text = "Choose File";
            this.btnFileDecompress.UseVisualStyleBackColor = true;
            this.btnFileDecompress.Click += new System.EventHandler(this.btnFileDecompress_Click);
            // 
            // btnDecompress
            // 
            this.btnDecompress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecompress.Location = new System.Drawing.Point(6, 61);
            this.btnDecompress.Name = "btnDecompress";
            this.btnDecompress.Size = new System.Drawing.Size(562, 29);
            this.btnDecompress.TabIndex = 11;
            this.btnDecompress.Text = "Decompress";
            this.btnDecompress.UseVisualStyleBackColor = true;
            this.btnDecompress.Click += new System.EventHandler(this.btnDecompress_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 345);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Compression";
            this.tabControl.ResumeLayout(false);
            this.tabCompress.ResumeLayout(false);
            this.tabDecompress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Label lblCompressOutput;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCompress;
        private System.Windows.Forms.TabPage tabDecompress;
        private System.Windows.Forms.Label lblDecompress;
        private System.Windows.Forms.OpenFileDialog openFileToCompress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDest;
        private System.Windows.Forms.Button btnDecompress;
        private System.Windows.Forms.Label lblDecompressFolder;
        private System.Windows.Forms.Button btnDestFolderDecompress;
        private System.Windows.Forms.Label lblFileDecompress;
        private System.Windows.Forms.Button btnFileDecompress;
        private System.Windows.Forms.OpenFileDialog openFileToDecompress;
        private System.Windows.Forms.Button btnOpenCompress;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnDestFolder;
        private System.Windows.Forms.Label lblDestFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDecompress;
    }
}

