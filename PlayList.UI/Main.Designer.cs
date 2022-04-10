namespace PlayList.UI
{
    partial class Main
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.textBoxAlbum = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(113, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(155, 64);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(224, 20);
            this.textBoxTitle.TabIndex = 1;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(113, 90);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Artist:";
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(155, 90);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(224, 20);
            this.textBoxArtist.TabIndex = 1;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(113, 116);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            // 
            // textBoxAlbum
            // 
            this.textBoxAlbum.Location = new System.Drawing.Point(155, 116);
            this.textBoxAlbum.Name = "textBoxAlbum";
            this.textBoxAlbum.Size = new System.Drawing.Size(224, 20);
            this.textBoxAlbum.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(116, 160);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.AutoSize = true;
            this.lblSongInfo.Location = new System.Drawing.Point(116, 26);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(84, 13);
            this.lblSongInfo.TabIndex = 3;
            this.lblSongInfo.Text = "Enter Song Info:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playListItemsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playListItemsToolStripMenuItem
            // 
            this.playListItemsToolStripMenuItem.Name = "playListItemsToolStripMenuItem";
            this.playListItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playListItemsToolStripMenuItem.Text = "Play List Items";
            this.playListItemsToolStripMenuItem.Click += new System.EventHandler(this.playListItemsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSongInfo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "My Playlist";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox textBoxAlbum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListItemsToolStripMenuItem;
    }
}

