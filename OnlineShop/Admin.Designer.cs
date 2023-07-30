
namespace OnlineShop
{
    partial class Admin
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_category = new System.Windows.Forms.Panel();
            this.pnl_report = new System.Windows.Forms.Panel();
            this.pnl_order = new System.Windows.Forms.Panel();
            this.pnl_item = new System.Windows.Forms.Panel();
            this.lbl_category2 = new System.Windows.Forms.Label();
            this.lbl_category1 = new System.Windows.Forms.Label();
            this.lbl_item1 = new System.Windows.Forms.Label();
            this.lbl_item2 = new System.Windows.Forms.Label();
            this.lbl_order1 = new System.Windows.Forms.Label();
            this.lbl_order2 = new System.Windows.Forms.Label();
            this.lbl_report1 = new System.Windows.Forms.Label();
            this.lbl_report2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_category.SuspendLayout();
            this.pnl_report.SuspendLayout();
            this.pnl_order.SuspendLayout();
            this.pnl_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome back,";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 3;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(726, 36);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(49, 16);
            this.lbl_login.TabIndex = 8;
            this.lbl_login.Text = "Logout";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(370, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(71, 39);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "      ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineShop.Properties.Resources.shopping_cart_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_category
            // 
            this.pnl_category.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_category.Controls.Add(this.lbl_category1);
            this.pnl_category.Controls.Add(this.lbl_category2);
            this.pnl_category.Location = new System.Drawing.Point(95, 118);
            this.pnl_category.Name = "pnl_category";
            this.pnl_category.Size = new System.Drawing.Size(300, 154);
            this.pnl_category.TabIndex = 9;
            this.pnl_category.Click += new System.EventHandler(this.pnl_category_Click);
            // 
            // pnl_report
            // 
            this.pnl_report.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_report.Controls.Add(this.lbl_report1);
            this.pnl_report.Controls.Add(this.lbl_report2);
            this.pnl_report.Location = new System.Drawing.Point(405, 281);
            this.pnl_report.Name = "pnl_report";
            this.pnl_report.Size = new System.Drawing.Size(300, 154);
            this.pnl_report.TabIndex = 10;
            // 
            // pnl_order
            // 
            this.pnl_order.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_order.Controls.Add(this.lbl_order1);
            this.pnl_order.Controls.Add(this.lbl_order2);
            this.pnl_order.Location = new System.Drawing.Point(95, 281);
            this.pnl_order.Name = "pnl_order";
            this.pnl_order.Size = new System.Drawing.Size(300, 154);
            this.pnl_order.TabIndex = 10;
            // 
            // pnl_item
            // 
            this.pnl_item.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_item.Controls.Add(this.lbl_item1);
            this.pnl_item.Controls.Add(this.lbl_item2);
            this.pnl_item.Location = new System.Drawing.Point(405, 118);
            this.pnl_item.Name = "pnl_item";
            this.pnl_item.Size = new System.Drawing.Size(300, 154);
            this.pnl_item.TabIndex = 10;
            // 
            // lbl_category2
            // 
            this.lbl_category2.AutoSize = true;
            this.lbl_category2.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_category2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category2.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_category2.Location = new System.Drawing.Point(66, 65);
            this.lbl_category2.Name = "lbl_category2";
            this.lbl_category2.Size = new System.Drawing.Size(163, 38);
            this.lbl_category2.TabIndex = 9;
            this.lbl_category2.Text = "Category";
            // 
            // lbl_category1
            // 
            this.lbl_category1.AutoSize = true;
            this.lbl_category1.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_category1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_category1.Location = new System.Drawing.Point(104, 45);
            this.lbl_category1.Name = "lbl_category1";
            this.lbl_category1.Size = new System.Drawing.Size(78, 21);
            this.lbl_category1.TabIndex = 10;
            this.lbl_category1.Text = "Manage";
            // 
            // lbl_item1
            // 
            this.lbl_item1.AutoSize = true;
            this.lbl_item1.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_item1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_item1.Location = new System.Drawing.Point(107, 48);
            this.lbl_item1.Name = "lbl_item1";
            this.lbl_item1.Size = new System.Drawing.Size(78, 21);
            this.lbl_item1.TabIndex = 12;
            this.lbl_item1.Text = "Manage";
            // 
            // lbl_item2
            // 
            this.lbl_item2.AutoSize = true;
            this.lbl_item2.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_item2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item2.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_item2.Location = new System.Drawing.Point(102, 68);
            this.lbl_item2.Name = "lbl_item2";
            this.lbl_item2.Size = new System.Drawing.Size(86, 38);
            this.lbl_item2.TabIndex = 11;
            this.lbl_item2.Text = "Item";
            // 
            // lbl_order1
            // 
            this.lbl_order1.AutoSize = true;
            this.lbl_order1.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_order1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_order1.Location = new System.Drawing.Point(107, 48);
            this.lbl_order1.Name = "lbl_order1";
            this.lbl_order1.Size = new System.Drawing.Size(78, 21);
            this.lbl_order1.TabIndex = 12;
            this.lbl_order1.Text = "Manage";
            // 
            // lbl_order2
            // 
            this.lbl_order2.AutoSize = true;
            this.lbl_order2.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_order2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order2.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_order2.Location = new System.Drawing.Point(92, 68);
            this.lbl_order2.Name = "lbl_order2";
            this.lbl_order2.Size = new System.Drawing.Size(105, 38);
            this.lbl_order2.TabIndex = 11;
            this.lbl_order2.Text = "Order";
            // 
            // lbl_report1
            // 
            this.lbl_report1.AutoSize = true;
            this.lbl_report1.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_report1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report1.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_report1.Location = new System.Drawing.Point(125, 48);
            this.lbl_report1.Name = "lbl_report1";
            this.lbl_report1.Size = new System.Drawing.Size(48, 21);
            this.lbl_report1.TabIndex = 12;
            this.lbl_report1.Text = "View";
            // 
            // lbl_report2
            // 
            this.lbl_report2.AutoSize = true;
            this.lbl_report2.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_report2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report2.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_report2.Location = new System.Drawing.Point(92, 68);
            this.lbl_report2.Name = "lbl_report2";
            this.lbl_report2.Size = new System.Drawing.Size(117, 38);
            this.lbl_report2.TabIndex = 11;
            this.lbl_report2.Text = "Report";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_report);
            this.Controls.Add(this.pnl_order);
            this.Controls.Add(this.pnl_item);
            this.Controls.Add(this.pnl_category);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_category.ResumeLayout(false);
            this.pnl_category.PerformLayout();
            this.pnl_report.ResumeLayout(false);
            this.pnl_report.PerformLayout();
            this.pnl_order.ResumeLayout(false);
            this.pnl_order.PerformLayout();
            this.pnl_item.ResumeLayout(false);
            this.pnl_item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_login;
        public System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_category;
        private System.Windows.Forms.Label lbl_category1;
        private System.Windows.Forms.Label lbl_category2;
        private System.Windows.Forms.Panel pnl_report;
        private System.Windows.Forms.Label lbl_report1;
        private System.Windows.Forms.Label lbl_report2;
        private System.Windows.Forms.Panel pnl_order;
        private System.Windows.Forms.Label lbl_order1;
        private System.Windows.Forms.Label lbl_order2;
        private System.Windows.Forms.Panel pnl_item;
        private System.Windows.Forms.Label lbl_item1;
        private System.Windows.Forms.Label lbl_item2;
    }
}