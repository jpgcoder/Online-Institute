namespace OnlineInstitute
{
    partial class Form1
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
            this.signupbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewclassesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Titr", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(170, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "به موسسه آنلاین ما خوش آمدید!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(260, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "برای ورود یا ثبت نام روی دکمه های زیر کلیک کنید.";
            // 
            // signupbtn
            // 
            this.signupbtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.signupbtn.Location = new System.Drawing.Point(260, 304);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(76, 37);
            this.signupbtn.TabIndex = 2;
            this.signupbtn.Text = "ثبت نام";
            this.signupbtn.UseVisualStyleBackColor = true;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginbtn.Location = new System.Drawing.Point(567, 304);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 37);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "ورود";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(209, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "در غیر این صورت برای مشاهده کلاس ها روی دکمه زیر کلیک کنید.";
            // 
            // viewclassesbtn
            // 
            this.viewclassesbtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.viewclassesbtn.Location = new System.Drawing.Point(403, 459);
            this.viewclassesbtn.Name = "viewclassesbtn";
            this.viewclassesbtn.Size = new System.Drawing.Size(118, 37);
            this.viewclassesbtn.TabIndex = 5;
            this.viewclassesbtn.Text = "مشاهده کلاس ها";
            this.viewclassesbtn.UseVisualStyleBackColor = true;
            this.viewclassesbtn.Click += new System.EventHandler(this.viewclassesbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineInstitute.Properties.Resources.green_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 577);
            this.Controls.Add(this.viewclassesbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "خوش آمدید!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewclassesbtn;
    }
}

