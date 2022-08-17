namespace assgmt3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_n = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_n.Location = new System.Drawing.Point(44, 22);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(79, 25);
            this.lbl_n.TabIndex = 0;
            this.lbl_n.Text = "product";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(44, 60);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(100, 25);
            this.lbl_d.TabIndex = 1;
            this.lbl_d.Text = "description";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_p.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_p.Location = new System.Drawing.Point(44, 99);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(54, 25);
            this.lbl_p.TabIndex = 2;
            this.lbl_p.Text = "price";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_p);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_n);
            this.Name = "UserControl1";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_n;
        private Label lbl_d;
        private Label lbl_p;
    }
}
