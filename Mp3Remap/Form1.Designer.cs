namespace Mp3Remap
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
            this.lblMp3Folder = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.fileNameArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameSong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadSongs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMp3Folder
            // 
            this.lblMp3Folder.AutoSize = true;
            this.lblMp3Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMp3Folder.Location = new System.Drawing.Point(12, 9);
            this.lblMp3Folder.Name = "lblMp3Folder";
            this.lblMp3Folder.Size = new System.Drawing.Size(207, 25);
            this.lblMp3Folder.TabIndex = 0;
            this.lblMp3Folder.Text = "Choose Mp3 Folder:";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(233, 74);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(139, 46);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 37);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(360, 31);
            this.txtPath.TabIndex = 2;
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameArtist,
            this.fileNameSong,
            this.artist,
            this.songName});
            this.dgvSongs.Location = new System.Drawing.Point(379, 9);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowTemplate.Height = 33;
            this.dgvSongs.Size = new System.Drawing.Size(1070, 879);
            this.dgvSongs.TabIndex = 3;
            // 
            // fileNameArtist
            // 
            this.fileNameArtist.HeaderText = "File Name Artist";
            this.fileNameArtist.Name = "fileNameArtist";
            // 
            // fileNameSong
            // 
            this.fileNameSong.HeaderText = "File Song Name";
            this.fileNameSong.Name = "fileNameSong";
            // 
            // artist
            // 
            this.artist.HeaderText = "Artist";
            this.artist.Name = "artist";
            // 
            // songName
            // 
            this.songName.HeaderText = "Song Name";
            this.songName.Name = "songName";
            // 
            // btnLoadSongs
            // 
            this.btnLoadSongs.Enabled = false;
            this.btnLoadSongs.Location = new System.Drawing.Point(80, 74);
            this.btnLoadSongs.Name = "btnLoadSongs";
            this.btnLoadSongs.Size = new System.Drawing.Size(139, 46);
            this.btnLoadSongs.TabIndex = 4;
            this.btnLoadSongs.Text = "Load Songs";
            this.btnLoadSongs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 842);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1955, 900);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadSongs);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.lblMp3Folder);
            this.Name = "Form1";
            this.Text = "Mp3 Remapper";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMp3Folder;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.Button btnLoadSongs;
        private System.Windows.Forms.Button btnSave;
    }
}

