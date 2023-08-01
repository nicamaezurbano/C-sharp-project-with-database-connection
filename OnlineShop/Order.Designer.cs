
namespace OnlineShop
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_order_list = new System.Windows.Forms.DataGridView();
            this.dgv_item_list = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_shipped = new System.Windows.Forms.Button();
            this.btn_packed = new System.Windows.Forms.Button();
            this.btn_delivered = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_brgy = new System.Windows.Forms.Label();
            this.lbl_municipality = new System.Windows.Forms.Label();
            this.lbl_province = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_list)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Order";
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
            // dgv_order_list
            // 
            this.dgv_order_list.AllowUserToAddRows = false;
            this.dgv_order_list.AllowUserToDeleteRows = false;
            this.dgv_order_list.AllowUserToOrderColumns = true;
            this.dgv_order_list.AllowUserToResizeRows = false;
            this.dgv_order_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order_list.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_order_list.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_order_list.Location = new System.Drawing.Point(11, 103);
            this.dgv_order_list.MultiSelect = false;
            this.dgv_order_list.Name = "dgv_order_list";
            this.dgv_order_list.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_order_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_order_list.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_order_list.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_order_list.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgv_order_list.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_order_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order_list.RowTemplate.Height = 20;
            this.dgv_order_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order_list.Size = new System.Drawing.Size(494, 189);
            this.dgv_order_list.TabIndex = 7;
            this.dgv_order_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_list_CellClick);
            // 
            // dgv_item_list
            // 
            this.dgv_item_list.AllowUserToAddRows = false;
            this.dgv_item_list.AllowUserToDeleteRows = false;
            this.dgv_item_list.AllowUserToOrderColumns = true;
            this.dgv_item_list.AllowUserToResizeRows = false;
            this.dgv_item_list.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_item_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_item_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_item_list.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_item_list.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_item_list.Location = new System.Drawing.Point(12, 298);
            this.dgv_item_list.MultiSelect = false;
            this.dgv_item_list.Name = "dgv_item_list";
            this.dgv_item_list.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_item_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_item_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_item_list.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_item_list.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgv_item_list.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dgv_item_list.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_item_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_item_list.RowTemplate.Height = 20;
            this.dgv_item_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_item_list.Size = new System.Drawing.Size(493, 148);
            this.dgv_item_list.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_province);
            this.groupBox1.Controls.Add(this.lbl_municipality);
            this.groupBox1.Controls.Add(this.lbl_brgy);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_contact);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(527, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // btn_shipped
            // 
            this.btn_shipped.BackColor = System.Drawing.Color.Snow;
            this.btn_shipped.Enabled = false;
            this.btn_shipped.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_shipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shipped.Location = new System.Drawing.Point(602, 354);
            this.btn_shipped.Name = "btn_shipped";
            this.btn_shipped.Size = new System.Drawing.Size(94, 36);
            this.btn_shipped.TabIndex = 20;
            this.btn_shipped.Text = "Shipped";
            this.btn_shipped.UseVisualStyleBackColor = false;
            this.btn_shipped.Click += new System.EventHandler(this.btn_shipped_Click);
            // 
            // btn_packed
            // 
            this.btn_packed.BackColor = System.Drawing.Color.Snow;
            this.btn_packed.Enabled = false;
            this.btn_packed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_packed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_packed.Location = new System.Drawing.Point(527, 298);
            this.btn_packed.Name = "btn_packed";
            this.btn_packed.Size = new System.Drawing.Size(94, 36);
            this.btn_packed.TabIndex = 19;
            this.btn_packed.Text = "Packed";
            this.btn_packed.UseVisualStyleBackColor = false;
            this.btn_packed.Click += new System.EventHandler(this.btn_packed_Click);
            // 
            // btn_delivered
            // 
            this.btn_delivered.BackColor = System.Drawing.Color.Snow;
            this.btn_delivered.Enabled = false;
            this.btn_delivered.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivered.Location = new System.Drawing.Point(677, 410);
            this.btn_delivered.Name = "btn_delivered";
            this.btn_delivered.Size = new System.Drawing.Size(94, 36);
            this.btn_delivered.TabIndex = 21;
            this.btn_delivered.Text = "Delivered";
            this.btn_delivered.UseVisualStyleBackColor = false;
            this.btn_delivered.Click += new System.EventHandler(this.btn_delivered_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(8, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_name.Location = new System.Drawing.Point(87, 33);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(49, 15);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "              ";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_contact.Location = new System.Drawing.Point(87, 58);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(49, 15);
            this.lbl_contact.TabIndex = 14;
            this.lbl_contact.Text = "              ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_email.Location = new System.Drawing.Point(87, 83);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(49, 15);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "              ";
            // 
            // lbl_brgy
            // 
            this.lbl_brgy.AllowDrop = true;
            this.lbl_brgy.AutoSize = true;
            this.lbl_brgy.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_brgy.Location = new System.Drawing.Point(87, 108);
            this.lbl_brgy.Name = "lbl_brgy";
            this.lbl_brgy.Size = new System.Drawing.Size(49, 15);
            this.lbl_brgy.TabIndex = 16;
            this.lbl_brgy.Text = "              ";
            // 
            // lbl_municipality
            // 
            this.lbl_municipality.AllowDrop = true;
            this.lbl_municipality.AutoSize = true;
            this.lbl_municipality.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_municipality.Location = new System.Drawing.Point(87, 127);
            this.lbl_municipality.Name = "lbl_municipality";
            this.lbl_municipality.Size = new System.Drawing.Size(49, 15);
            this.lbl_municipality.TabIndex = 17;
            this.lbl_municipality.Text = "              ";
            // 
            // lbl_province
            // 
            this.lbl_province.AllowDrop = true;
            this.lbl_province.AutoSize = true;
            this.lbl_province.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_province.Location = new System.Drawing.Point(87, 146);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(49, 15);
            this.lbl_province.TabIndex = 18;
            this.lbl_province.Text = "              ";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_delivered);
            this.Controls.Add(this.btn_shipped);
            this.Controls.Add(this.btn_packed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_item_list);
            this.Controls.Add(this.dgv_order_list);
            this.Controls.Add(this.panel1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_order_list;
        private System.Windows.Forms.DataGridView dgv_item_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_shipped;
        private System.Windows.Forms.Button btn_packed;
        private System.Windows.Forms.Button btn_delivered;
        private System.Windows.Forms.Label lbl_brgy;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_municipality;
        private System.Windows.Forms.Label lbl_province;
    }
}