namespace UserInterface_AM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PlayButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.ShareButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListBox();
            this.RemoveFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Silver;
            this.PlayButton.Location = new System.Drawing.Point(32, 141);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(142, 37);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayFile);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Silver;
            this.SearchButton.Location = new System.Drawing.Point(33, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(141, 40);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search/Download";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchFiles);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.SignOutButton.Location = new System.Drawing.Point(615, 12);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(75, 40);
            this.SignOutButton.TabIndex = 2;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOut);
            // 
            // ShareButton
            // 
            this.ShareButton.BackColor = System.Drawing.Color.Silver;
            this.ShareButton.Location = new System.Drawing.Point(471, 141);
            this.ShareButton.Name = "ShareButton";
            this.ShareButton.Size = new System.Drawing.Size(141, 37);
            this.ShareButton.TabIndex = 3;
            this.ShareButton.Text = "Share";
            this.ShareButton.UseVisualStyleBackColor = false;
            this.ShareButton.Click += new System.EventHandler(this.ShareButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Silver;
            this.EditButton.Location = new System.Drawing.Point(253, 141);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(141, 37);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditFile);
            // 
            // AddFile
            // 
            this.AddFile.BackColor = System.Drawing.Color.Silver;
            this.AddFile.Location = new System.Drawing.Point(32, 78);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(142, 37);
            this.AddFile.TabIndex = 5;
            this.AddFile.Text = "Add File(s)";
            this.AddFile.UseVisualStyleBackColor = false;
            this.AddFile.Click += new System.EventHandler(this.ImportFiles);
            // 
            // FileList
            // 
            this.FileList.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileList.FormattingEnabled = true;
            this.FileList.ItemHeight = 16;
            this.FileList.Location = new System.Drawing.Point(12, 224);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(702, 340);
            this.FileList.TabIndex = 6;
            // 
            // RemoveFile
            // 
            this.RemoveFile.BackColor = System.Drawing.Color.Silver;
            this.RemoveFile.Location = new System.Drawing.Point(253, 78);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(141, 37);
            this.RemoveFile.TabIndex = 7;
            this.RemoveFile.Text = "Remove File";
            this.RemoveFile.UseVisualStyleBackColor = false;
            this.RemoveFile.Click += new System.EventHandler(this.Remove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "File List:";
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.Silver;
            this.ClearList.ForeColor = System.Drawing.Color.Black;
            this.ClearList.Location = new System.Drawing.Point(471, 78);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(141, 37);
            this.ClearList.TabIndex = 9;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.Clear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amazing Music";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(726, 569);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveFile);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ShareButton);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button ShareButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.Button RemoveFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Label label3;
    }
}