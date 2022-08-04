namespace assgmt3
{
    partial class Form2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtadm = new System.Windows.Forms.TextBox();
            this.txtpsd = new System.Windows.Forms.TextBox();
            this.lblpsd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(98, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "user name";
            // 
            // txtadm
            // 
            this.txtadm.Location = new System.Drawing.Point(243, 58);
            this.txtadm.Name = "txtadm";
            this.txtadm.Size = new System.Drawing.Size(150, 31);
            this.txtadm.TabIndex = 1;
            this.txtadm.TextChanged += new System.EventHandler(this.txtadm_TextChanged);
            // 
            // txtpsd
            // 
            this.txtpsd.Location = new System.Drawing.Point(243, 135);
            this.txtpsd.Name = "txtpsd";
            this.txtpsd.Size = new System.Drawing.Size(150, 31);
            this.txtpsd.TabIndex = 2;
            // 
            // lblpsd
            // 
            this.lblpsd.AutoSize = true;
            this.lblpsd.Location = new System.Drawing.Point(119, 138);
            this.lblpsd.Name = "lblpsd";
            this.lblpsd.Size = new System.Drawing.Size(89, 25);
            this.lblpsd.TabIndex = 3;
            this.lblpsd.Text = "password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblpsd);
            this.Controls.Add(this.txtpsd);
            this.Controls.Add(this.txtadm);
            this.Controls.Add(this.lbl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        public TextBox txtadm;
        private TextBox txtpsd;
        private Label lblpsd;
        private Button button1;
    }
}