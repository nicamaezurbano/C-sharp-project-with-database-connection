
namespace OnlineShop
{
    partial class Report
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
            this.crpt_viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpt_viewer
            // 
            this.crpt_viewer.ActiveViewIndex = -1;
            this.crpt_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpt_viewer.Location = new System.Drawing.Point(0, 0);
            this.crpt_viewer.Name = "crpt_viewer";
            this.crpt_viewer.Size = new System.Drawing.Size(784, 461);
            this.crpt_viewer.TabIndex = 0;
            this.crpt_viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.crpt_viewer);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_viewer;
    }
}