
namespace EduvosPlanner
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_Username = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.Bclick_OpenID = new System.Windows.Forms.Button();
            this.T_Username = new System.Windows.Forms.TextBox();
            this.T_Password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // L_Username
            // 
            this.L_Username.AutoSize = true;
            this.L_Username.Location = new System.Drawing.Point(168, 225);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(55, 13);
            this.L_Username.TabIndex = 1;
            this.L_Username.Text = "Username";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(168, 266);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(53, 13);
            this.L_Password.TabIndex = 2;
            this.L_Password.Text = "Password";
            // 
            // Bclick_OpenID
            // 
            this.Bclick_OpenID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bclick_OpenID.Image = ((System.Drawing.Image)(resources.GetObject("Bclick_OpenID.Image")));
            this.Bclick_OpenID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bclick_OpenID.Location = new System.Drawing.Point(237, 313);
            this.Bclick_OpenID.Name = "Bclick_OpenID";
            this.Bclick_OpenID.Size = new System.Drawing.Size(158, 45);
            this.Bclick_OpenID.TabIndex = 3;
            this.Bclick_OpenID.Text = "OpenID Connect";
            this.Bclick_OpenID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bclick_OpenID.UseVisualStyleBackColor = false;
            this.Bclick_OpenID.Click += new System.EventHandler(this.b_OpenID_Click);
            // 
            // T_Username
            // 
            this.T_Username.Location = new System.Drawing.Point(254, 225);
            this.T_Username.Name = "T_Username";
            this.T_Username.Size = new System.Drawing.Size(198, 20);
            this.T_Username.TabIndex = 4;
            this.T_Username.Text = "student@vossie.net";
            this.T_Username.TextChanged += new System.EventHandler(this.t_Username_TextChanged);
            // 
            // T_Password
            // 
            this.T_Password.Location = new System.Drawing.Point(254, 266);
            this.T_Password.Name = "T_Password";
            this.T_Password.Size = new System.Drawing.Size(198, 20);
            this.T_Password.TabIndex = 5;
            this.T_Password.Text = "#12Aug2024";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 467);
            this.Controls.Add(this.T_Password);
            this.Controls.Add(this.T_Username);
            this.Controls.Add(this.Bclick_OpenID);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Username);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button Bclick_OpenID;
        private System.Windows.Forms.TextBox T_Username;
        private System.Windows.Forms.TextBox T_Password;
    }
}

