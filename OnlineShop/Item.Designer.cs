
namespace OnlineShop
{
    partial class Item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lbl_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 5;
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.BackColor = System.Drawing.Color.RosyBrown;
            this.lbl_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.White;
            this.lbl_back.Location = new System.Drawing.Point(726, 36);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(39, 16);
            this.lbl_back.TabIndex = 8;
            this.lbl_back.Text = "Back";
            this.lbl_back.Click += new System.EventHandler(this.lbl_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Item";
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
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.AllowUserToOrderColumns = true;
            this.dgv_list.AllowUserToResizeRows = false;
            this.dgv_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_list.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_list.Location = new System.Drawing.Point(27, 103);
            this.dgv_list.MultiSelect = false;
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_list.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_list.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgv_list.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.RowTemplate.Height = 28;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(443, 343);
            this.dgv_list.TabIndex = 6;
            this.dgv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellClick);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_name.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_name.Location = new System.Drawing.Point(497, 125);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(260, 23);
            this.txt_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(494, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(494, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(494, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Size";
            // 
            // txt_size
            // 
            this.txt_size.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_size.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_size.Location = new System.Drawing.Point(497, 257);
            this.txt_size.Margin = new System.Windows.Forms.Padding(5);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(124, 23);
            this.txt_size.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(630, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Color";
            // 
            // txt_color
            // 
            this.txt_color.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_color.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_color.Location = new System.Drawing.Point(633, 257);
            this.txt_color.Margin = new System.Windows.Forms.Padding(5);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(124, 23);
            this.txt_color.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(494, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Selling Price";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_price.Font = new System.Drawing.Font("Arial", 10F);
            this.txt_price.Location = new System.Drawing.Point(497, 323);
            this.txt_price.Margin = new System.Windows.Forms.Padding(5);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(124, 23);
            this.txt_price.TabIndex = 15;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(633, 381);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 36);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(497, 381);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(124, 36);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(630, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_status.Font = new System.Drawing.Font("Arial", 10F);
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Posted",
            "Hidden"});
            this.cmb_status.Location = new System.Drawing.Point(633, 322);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(124, 24);
            this.cmb_status.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(535, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(551, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(569, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F);
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(673, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "*";
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_category.Font = new System.Drawing.Font("Arial", 10F);
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(497, 191);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(260, 24);
            this.cmb_category.TabIndex = 26;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_category);
            this.Name = "Item";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_category;
    }
}