namespace VBRSupport
{
    partial class CustomerHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHistory));
            this.TSB = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBCustomerIDSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TBEmailSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TBPostCodeSearch = new System.Windows.Forms.ToolStripTextBox();
            this.buEndDate = new System.Windows.Forms.ToolStripButton();
            this.buReportHistory = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.TSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // TSB
            // 
            this.TSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TBCustomerIDSearch,
            this.toolStripLabel2,
            this.TBEmailSearch,
            this.toolStripLabel3,
            this.TBPostCodeSearch,
            this.buEndDate,
            this.buReportHistory});
            this.TSB.Location = new System.Drawing.Point(0, 0);
            this.TSB.Name = "TSB";
            this.TSB.Size = new System.Drawing.Size(905, 25);
            this.TSB.TabIndex = 0;
            this.TSB.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "CustomerID";
            // 
            // TBCustomerIDSearch
            // 
            this.TBCustomerIDSearch.Name = "TBCustomerIDSearch";
            this.TBCustomerIDSearch.Size = new System.Drawing.Size(100, 25);
            this.TBCustomerIDSearch.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "Email";
            // 
            // TBEmailSearch
            // 
            this.TBEmailSearch.Name = "TBEmailSearch";
            this.TBEmailSearch.Size = new System.Drawing.Size(170, 25);
            this.TBEmailSearch.TextChanged += new System.EventHandler(this.TBEmailSearch_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel3.Text = "PostCode";
            // 
            // TBPostCodeSearch
            // 
            this.TBPostCodeSearch.Name = "TBPostCodeSearch";
            this.TBPostCodeSearch.Size = new System.Drawing.Size(100, 25);
            this.TBPostCodeSearch.TextChanged += new System.EventHandler(this.TBPostCodeSearch_TextChanged);
            // 
            // buEndDate
            // 
            this.buEndDate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buEndDate.Name = "buEndDate";
            this.buEndDate.Size = new System.Drawing.Size(58, 22);
            this.buEndDate.Text = "End Date";
            this.buEndDate.ToolTipText = "End Date Before 15Days";
            this.buEndDate.Click += new System.EventHandler(this.buEndDate_Click);
            // 
            // buReportHistory
            // 
            this.buReportHistory.Image = global::VBRSupport.Properties.Resources.Report;
            this.buReportHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buReportHistory.Name = "buReportHistory";
            this.buReportHistory.Size = new System.Drawing.Size(62, 22);
            this.buReportHistory.Text = "Report";
            this.buReportHistory.Click += new System.EventHandler(this.buReportHistory_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.BackgroundColor = System.Drawing.Color.White;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point(0, 25);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 22;
            this.dgList.Size = new System.Drawing.Size(905, 259);
            this.dgList.TabIndex = 1;
            // 
            // CustomerHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 284);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.TSB);
            this.Name = "CustomerHistory";
            this.Tag = "FullSize";
            this.Text = "CustomerHistory";
            this.Load += new System.EventHandler(this.CustomerHistory_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerHistory_FormClosing);
            this.TSB.ResumeLayout(false);
            this.TSB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSB;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBCustomerIDSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TBEmailSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox TBPostCodeSearch;
        private System.Windows.Forms.ToolStripButton buEndDate;
        private System.Windows.Forms.ToolStripButton buReportHistory;
    }
}