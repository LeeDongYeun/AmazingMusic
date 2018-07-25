namespace UserInterface_AM
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveTempo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EditFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cutStart = new System.Windows.Forms.TextBox();
            this.cutFinish = new System.Windows.Forms.TextBox();
            this.CommitCut = new System.Windows.Forms.Button();
            this.SavePitch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pitchTrackbar = new System.Windows.Forms.TrackBar();
            this.tempoTrackbar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Red;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 37);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.BackToMain);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adjust Pitch: (Scale pitch from 0.5 to 2 times the origninal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adjust Tempo: (Scale tempo from 0.8 to 2 times the original)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(379, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edit";
            // 
            // SaveTempo
            // 
            this.SaveTempo.BackColor = System.Drawing.Color.Silver;
            this.SaveTempo.Location = new System.Drawing.Point(560, 505);
            this.SaveTempo.Name = "SaveTempo";
            this.SaveTempo.Size = new System.Drawing.Size(107, 56);
            this.SaveTempo.TabIndex = 12;
            this.SaveTempo.Text = "Save Tempo Changes";
            this.SaveTempo.UseVisualStyleBackColor = false;
            this.SaveTempo.Click += new System.EventHandler(this.SaveTempo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "File:";
            // 
            // EditFile
            // 
            this.EditFile.AutoSize = true;
            this.EditFile.BackColor = System.Drawing.Color.Transparent;
            this.EditFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFile.ForeColor = System.Drawing.Color.White;
            this.EditFile.Location = new System.Drawing.Point(105, 88);
            this.EditFile.Name = "EditFile";
            this.EditFile.Size = new System.Drawing.Size(46, 18);
            this.EditFile.TabIndex = 15;
            this.EditFile.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cut Start Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cut Final Position:";
            // 
            // cutStart
            // 
            this.cutStart.Location = new System.Drawing.Point(270, 188);
            this.cutStart.MaxLength = 3;
            this.cutStart.Name = "cutStart";
            this.cutStart.Size = new System.Drawing.Size(98, 22);
            this.cutStart.TabIndex = 18;
            this.cutStart.TextChanged += new System.EventHandler(this.cutStart_TextChanged);
            // 
            // cutFinish
            // 
            this.cutFinish.Location = new System.Drawing.Point(270, 253);
            this.cutFinish.MaxLength = 3;
            this.cutFinish.Name = "cutFinish";
            this.cutFinish.Size = new System.Drawing.Size(98, 22);
            this.cutFinish.TabIndex = 19;
            this.cutFinish.TextChanged += new System.EventHandler(this.cutFinish_TextChanged);
            // 
            // CommitCut
            // 
            this.CommitCut.BackColor = System.Drawing.Color.Silver;
            this.CommitCut.Location = new System.Drawing.Point(402, 201);
            this.CommitCut.Name = "CommitCut";
            this.CommitCut.Size = new System.Drawing.Size(107, 56);
            this.CommitCut.TabIndex = 20;
            this.CommitCut.Text = "Commit";
            this.CommitCut.UseVisualStyleBackColor = false;
            this.CommitCut.Click += new System.EventHandler(this.CommitCut_Click);
            // 
            // SavePitch
            // 
            this.SavePitch.BackColor = System.Drawing.Color.Silver;
            this.SavePitch.Location = new System.Drawing.Point(560, 354);
            this.SavePitch.Name = "SavePitch";
            this.SavePitch.Size = new System.Drawing.Size(107, 56);
            this.SavePitch.TabIndex = 23;
            this.SavePitch.Text = "Save Pitch Changes";
            this.SavePitch.UseVisualStyleBackColor = false;
            this.SavePitch.Click += new System.EventHandler(this.SavePitch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cut File:";
            // 
            // pitchTrackbar
            // 
            this.pitchTrackbar.BackColor = System.Drawing.Color.Azure;
            this.pitchTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pitchTrackbar.Location = new System.Drawing.Point(46, 354);
            this.pitchTrackbar.Maximum = 20;
            this.pitchTrackbar.Minimum = 5;
            this.pitchTrackbar.Name = "pitchTrackbar";
            this.pitchTrackbar.Size = new System.Drawing.Size(463, 56);
            this.pitchTrackbar.TabIndex = 25;
            this.pitchTrackbar.Value = 5;
            // 
            // tempoTrackbar
            // 
            this.tempoTrackbar.BackColor = System.Drawing.Color.Azure;
            this.tempoTrackbar.Location = new System.Drawing.Point(51, 505);
            this.tempoTrackbar.Maximum = 20;
            this.tempoTrackbar.Minimum = 8;
            this.tempoTrackbar.Name = "tempoTrackbar";
            this.tempoTrackbar.Size = new System.Drawing.Size(458, 56);
            this.tempoTrackbar.TabIndex = 26;
            this.tempoTrackbar.Value = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(48, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "0.5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(478, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "2.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(191, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "1.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Azure;
            this.label12.Location = new System.Drawing.Point(340, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "1.5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Azure;
            this.label13.Location = new System.Drawing.Point(478, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "2.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Location = new System.Drawing.Point(303, 544);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "1.5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Azure;
            this.label15.Location = new System.Drawing.Point(123, 544);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "1.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Azure;
            this.label16.Location = new System.Drawing.Point(55, 544);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "0.8";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 663);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tempoTrackbar);
            this.Controls.Add(this.pitchTrackbar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SavePitch);
            this.Controls.Add(this.CommitCut);
            this.Controls.Add(this.cutFinish);
            this.Controls.Add(this.cutStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.pitchTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveTempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EditFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cutStart;
        private System.Windows.Forms.TextBox cutFinish;
        private System.Windows.Forms.Button CommitCut;
        private System.Windows.Forms.Button SavePitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar pitchTrackbar;
        private System.Windows.Forms.TrackBar tempoTrackbar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}