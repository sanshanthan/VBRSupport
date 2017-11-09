namespace VBRSupport
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.TSB = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TBCustomerIDSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TBEmailSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgListCL = new System.Windows.Forms.DataGridView();
            this.TSB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCL)).BeginInit();
            this.SuspendLayout();
            // 
            // TSB
            // 
            this.TSB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TBCustomerIDSearch,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.TBEmailSearch,
            this.toolStripButton1});
            this.TSB.Location = new System.Drawing.Point(0, 0);
            this.TSB.Name = "TSB";
            this.TSB.Size = new System.Drawing.Size(791, 25);
            this.TSB.TabIndex = 2;
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
            this.TBCustomerIDSearch.TextChanged += new System.EventHandler(this.TBCustomerIDSearch_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel3.Text = "Name";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // TBEmailSearch
            // 
            this.TBEmailSearch.Name = "TBEmailSearch";
            this.TBEmailSearch.Size = new System.Drawing.Size(170, 25);
            this.TBEmailSearch.TextChanged += new System.EventHandler(this.TBEmailSearch_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgListCL
            // 
            this.dgListCL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListCL.Location = new System.Drawing.Point(0, 25);
            this.dgListCL.Name = "dgListCL";
            this.dgListCL.Size = new System.Drawing.Size(791, 426);
            this.dgListCL.TabIndex = 3;
            this.dgListCL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListCL_CellContentClick);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 451);
            this.Controls.Add(this.dgListCL);
            this.Controls.Add(this.TSB);
            this.Name = "CustomerList";
            this.Tag = "FullSize";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerList_FormClosing);
            this.TSB.ResumeLayout(false);
            this.TSB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSB;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TBCustomerIDSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TBEmailSearch;
        private System.Windows.Forms.DataGridView dgListCL;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}