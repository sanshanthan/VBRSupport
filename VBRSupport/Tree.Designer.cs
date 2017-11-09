namespace VBRSupport
{
    partial class Tree
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
            this.buMinimize = new System.Windows.Forms.Button();
            this.buClose = new System.Windows.Forms.Button();
            this.buNotAvailableNow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buCusHistory = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buMinimize
            // 
            this.buMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buMinimize.Location = new System.Drawing.Point(1, 411);
            this.buMinimize.Name = "buMinimize";
            this.buMinimize.Size = new System.Drawing.Size(88, 33);
            this.buMinimize.TabIndex = 0;
            this.buMinimize.Text = "Minimize";
            this.buMinimize.UseVisualStyleBackColor = true;
            this.buMinimize.Click += new System.EventHandler(this.buMinimize_Click);
            // 
            // buClose
            // 
            this.buClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buClose.BackColor = System.Drawing.Color.Transparent;
            this.buClose.Location = new System.Drawing.Point(125, 411);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(88, 33);
            this.buClose.TabIndex = 1;
            this.buClose.Text = "Close";
            this.buClose.UseVisualStyleBackColor = false;
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // buNotAvailableNow
            // 
            this.buNotAvailableNow.Location = new System.Drawing.Point(1, 221);
            this.buNotAvailableNow.Name = "buNotAvailableNow";
            this.buNotAvailableNow.Size = new System.Drawing.Size(212, 37);
            this.buNotAvailableNow.TabIndex = 2;
            this.buNotAvailableNow.Text = "Not Available Now ";
            this.buNotAvailableNow.UseVisualStyleBackColor = true;
            this.buNotAvailableNow.Click += new System.EventHandler(this.buNotAvailableNow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "No Respond Last 30Days";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Due Customers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buCusHistory
            // 
            this.buCusHistory.Location = new System.Drawing.Point(1, 135);
            this.buCusHistory.Name = "buCusHistory";
            this.buCusHistory.Size = new System.Drawing.Size(212, 37);
            this.buCusHistory.TabIndex = 7;
            this.buCusHistory.Text = "Customer History";
            this.buCusHistory.UseVisualStyleBackColor = true;
            this.buCusHistory.Click += new System.EventHandler(this.buCusHistory_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "All Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 37);
            this.button5.TabIndex = 8;
            this.button5.Text = "New Customers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Image = global::VBRSupport.Properties.Resources.User_Male;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Customer Management";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(214, 446);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buCusHistory);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buNotAvailableNow);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.buMinimize);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tree";
            this.Tag = "Tree";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Tree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buMinimize;
        private System.Windows.Forms.Button buClose;
        private System.Windows.Forms.Button buNotAvailableNow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buCusHistory;
        private System.Windows.Forms.Button button5;
    }
}