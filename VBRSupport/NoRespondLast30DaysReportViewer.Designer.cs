namespace VBRSupport
{
    partial class NoRespondLast30DaysReportViewer
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
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "VBRSupport.NoRespondLast30DaysReport.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(446, 301);
            this.ReportViewer.TabIndex = 0;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = typeof(HistoryModel);
            // 
            // NoRespondLast30DaysReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.ReportViewer);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "NoRespondLast30DaysReportViewer";
            this.Tag = "FullSize";
            this.Text = "No Respond Last 30 Days Report Viewer";
            this.Load += new System.EventHandler(this.NoRespondLast30DaysReportViewer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoRespondLast30DaysReportViewer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource BindingSource;
    }
}