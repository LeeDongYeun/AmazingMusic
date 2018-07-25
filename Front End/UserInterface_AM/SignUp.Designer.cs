namespace UserInterface_AM
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterEmail = new System.Windows.Forms.TextBox();
            this.CreatePassword = new System.Windows.Forms.TextBox();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BacktoSignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter email address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Set Password:";
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Location = new System.Drawing.Point(155, 269);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.Size = new System.Drawing.Size(275, 22);
            this.RegisterEmail.TabIndex = 5;
            this.RegisterEmail.TextChanged += new System.EventHandler(this.EmailText);
            // 
            // CreatePassword
            // 
            this.CreatePassword.Location = new System.Drawing.Point(155, 368);
            this.CreatePassword.Name = "CreatePassword";
            this.CreatePassword.Size = new System.Drawing.Size(275, 22);
            this.CreatePassword.TabIndex = 6;
            this.CreatePassword.Click += new System.EventHandler(this.PasswordText);
            this.CreatePassword.TextChanged += new System.EventHandler(this.PasswordText);
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.BlueViolet;
            this.CreateAccount.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.Location = new System.Drawing.Point(206, 421);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(178, 81);
            this.CreateAccount.TabIndex = 9;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = false;
            this.CreateAccount.Click += new System.EventHandler(this.Create);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 106);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BacktoSignIn
            // 
            this.BacktoSignIn.BackColor = System.Drawing.Color.Red;
            this.BacktoSignIn.Location = new System.Drawing.Point(12, 12);
            this.BacktoSignIn.Name = "BacktoSignIn";
            this.BacktoSignIn.Size = new System.Drawing.Size(87, 36);
            this.BacktoSignIn.TabIndex = 12;
            this.BacktoSignIn.Text = "Back";
            this.BacktoSignIn.UseVisualStyleBackColor = false;
            this.BacktoSignIn.Click += new System.EventHandler(this.BackToSignIn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "(passwords are not case sensitive)";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BacktoSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.CreatePassword);
            this.Controls.Add(this.RegisterEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegisterEmail;
        private System.Windows.Forms.TextBox CreatePassword;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BacktoSignIn;
        private System.Windows.Forms.Label label4;
    }
}