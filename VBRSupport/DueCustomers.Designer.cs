namespace VBRSupport
{
    partial class DueCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DueCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.TSBReport = new System.Windows.Forms.ToolStripButton();
            this.TSBDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TS
            // 
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBReport,
            this.TSBDelete});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TS.Size = new System.Drawing.Size(721, 25);
            this.TS.TabIndex = 2;
            this.TS.Text = "toolStrip1";
            // 
            // TSBReport
            // 
            this.TSBReport.Image = ((System.Drawing.Image)(resources.GetObject("TSBReport.Image")));
            this.TSBReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBReport.Name = "TSBReport";
            this.TSBReport.Size = new System.Drawing.Size(62, 22);
            this.TSBReport.Text = "Report";
            this.TSBReport.Click += new System.EventHandler(this.TSBReport_Click);
            // 
            // TSBDelete
            // 
            this.TSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelete.Image")));
            this.TSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelete.Name = "TSBDelete";
            this.TSBDelete.Size = new System.Drawing.Size(60, 22);
            this.TSBDelete.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 22;
            this.dataGridView1.Size = new System.Drawing.Size(721, 373);
            this.dataGridView1.TabIndex = 5;
            // 
            // DueCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TS);
            this.Name = "DueCustomers";
            this.Tag = "FullSize";
            this.Text = "DueCustomers";
            this.Load += new System.EventHandler(this.DueCustomers_Load);
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.ToolStripButton TSBReport;
        private System.Windows.Forms.ToolStripButton TSBDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}