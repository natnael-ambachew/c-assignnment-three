namespace assgmt3
{
    partial class form9
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl11 = new assgmt3.UserControl1();
            this.userControl12 = new assgmt3.UserControl1();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Controls.Add(this.userControl12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 396);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(225, 225);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(3, 234);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(225, 225);
            this.userControl12.TabIndex = 1;
            // 
            // form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "form9";
            this.Text = "form9";
            this.Load += new System.EventHandler(this.form9_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private UserControl1 userControl11;
        private UserControl1 userControl12;
    }
}