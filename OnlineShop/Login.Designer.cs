
namespace OnlineShop
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ck_showPass = new System.Windows.Forms.CheckBox();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineShop.Properties.Resources.shopping_cart_2;
            this.pictureBox1.Location = new System.Drawing.Point(355, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Location = new System.Drawing.Point(168, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 10);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ck_showPass);
            this.panel3.Controls.Add(this.link_register);
            this.panel3.Controls.Add(this.btn_login);
            this.panel3.Controls.Add(this.txtBox_pass);
            this.panel3.Controls.Add(this.txtBox_email);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(168, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 186);
            this.panel3.TabIndex = 3;
            // 
            // ck_showPass
            // 
            this.ck_showPass.AutoSize = true;
            this.ck_showPass.Location = new System.Drawing.Point(307, 106);
            this.ck_showPass.Name = "ck_showPass";
            this.ck_showPass.Size = new System.Drawing.Size(99, 17);
            this.ck_showPass.TabIndex = 6;
            this.ck_showPass.Text = "show password";
            this.ck_showPass.UseVisualStyleBackColor = true;
            this.ck_showPass.CheckedChanged += new System.EventHandler(this.ck_showPass_CheckedChanged);
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_register.LinkColor = System.Drawing.Color.DarkRed;
            this.link_register.Location = new System.Drawing.Point(237, 138);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(63, 18);
            this.link_register.TabIndex = 5;
            this.link_register.TabStop = true;
            this.link_register.Text = "Register";
            this.link_register.VisitedLinkColor = System.Drawing.Color.IndianRed;
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(151, 135);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 25);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pass.Location = new System.Drawing.Point(140, 74);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(266, 26);
            this.txtBox_pass.TabIndex = 3;
            this.txtBox_pass.TextChanged += new System.EventHandler(this.txtBox_pass_TextChanged);
            // 
            // txtBox_email
            // 
            this.txtBox_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBox_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_email.Location = new System.Drawing.Point(140, 39);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(266, 26);
            this.txtBox_email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.CheckBox ck_showPass;
    }
}

