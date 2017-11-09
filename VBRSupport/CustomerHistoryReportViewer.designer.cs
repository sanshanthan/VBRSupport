namespace VBRSupport
{
    partial class CustomerHistoryReportViewer
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewer
            // 
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HistoryModel";
            reportDataSource1.Value = this.BindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "VBRSupport.CustomerHistoryReport.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(622, 269);
            this.ReportViewer.TabIndex = 0;
            this.ReportViewer.Tag = "";
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(HistoryModel);
            // 
            // CustomerHistoryReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 269);
            this.Controls.Add(this.ReportViewer);
            this.Name = "CustomerHistoryReportViewer";
            this.Tag = "FullSize";
            this.Text = "CustomerHistoryReportViewer";
            this.Load += new System.EventHandler(this.CustomerHistoryReportViewer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerHistoryReportViewer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}