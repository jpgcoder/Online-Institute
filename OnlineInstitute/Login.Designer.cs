namespace OnlineInstitute
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(225, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(225, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernametxt.Location = new System.Drawing.Point(48, 53);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(152, 34);
            this.usernametxt.TabIndex = 2;
            // 
            // passtxt
            // 
            this.passtxt.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passtxt.Location = new System.Drawing.Point(48, 109);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(152, 34);
            this.passtxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("B Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginBtn.Location = new System.Drawing.Point(125, 173);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 39);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "ورود";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ورود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginBtn;
    }
}