namespace VBRSupport
{
    partial class Not_AvailableCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Not_AvailableCustomers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.TSBReport = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // TS
            // 
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBReport});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.TS.Size = new System.Drawing.Size(764, 25);
            this.TS.TabIndex = 0;
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
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.AllowUserToResizeRows = false;
            this.dgList.BackgroundColor = System.Drawing.Color.White;
            this.dgList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgList.ColumnHeadersHeight = 35;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.GridColor = System.Drawing.Color.SkyBlue;
            this.dgList.Location = new System.Drawing.Point(0, 25);
            this.dgList.Margin = new System.Windows.Forms.Padding(4);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 22;
            this.dgList.Size = new System.Drawing.Size(764, 415);
            this.dgList.TabIndex = 4;
           // this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            // 
            // Not_AvailableCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 440);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.TS);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Not_AvailableCustomers";
            this.Tag = "FullSize";
            this.Text = "Not Available Customers";
            this.Load += new System.EventHandler(this.Not_AvailableCustomers_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Not_AvailableCustomers_FormClosing);
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.ToolStripButton TSBReport;
        private System.Windows.Forms.DataGridView dgList;
    }
}