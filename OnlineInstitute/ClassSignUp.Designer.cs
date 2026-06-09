namespace OnlineInstitute
{
    partial class ClassSignUp
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
            this.classlist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.answersbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.question2answer4 = new System.Windows.Forms.RadioButton();
            this.question2answer3 = new System.Windows.Forms.RadioButton();
            this.question2answer2 = new System.Windows.Forms.RadioButton();
            this.question2answer1 = new System.Windows.Forms.RadioButton();
            this.questionTwo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.question3answer4 = new System.Windows.Forms.RadioButton();
            this.question3answer3 = new System.Windows.Forms.RadioButton();
            this.question3answer2 = new System.Windows.Forms.RadioButton();
            this.question3answer1 = new System.Windows.Forms.RadioButton();
            this.questionThree = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.question1answer4 = new System.Windows.Forms.RadioButton();
            this.question1answer3 = new System.Windows.Forms.RadioButton();
            this.question1answer2 = new System.Windows.Forms.RadioButton();
            this.question1answer1 = new System.Windows.Forms.RadioButton();
            this.questionOne = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // classlist
            // 
            this.classlist.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.classlist.FormattingEnabled = true;
            this.classlist.ItemHeight = 24;
            this.classlist.Items.AddRange(new object[] {
            "زبان انگلیسی",
            "زبان آلمانی",
            "زبان ترکی",
            "پایتون",
            "سی شارپ"});
            this.classlist.Location = new System.Drawing.Point(185, 75);
            this.classlist.Name = "classlist";
            this.classlist.Size = new System.Drawing.Size(138, 124);
            this.classlist.TabIndex = 0;
            this.classlist.SelectedIndexChanged += new System.EventHandler(this.classlist_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernamelbl);
            this.groupBox1.Controls.Add(this.namelbl);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("B Traffic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usernamelbl.Location = new System.Drawing.Point(91, 16);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernamelbl.Size = new System.Drawing.Size(48, 24);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "label2";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("B Traffic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.namelbl.Location = new System.Drawing.Point(313, 16);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(48, 24);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::OnlineInstitute.Properties.Resources.vertical_black_chalk_board_texture_vector_background_522680_368;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.answersbtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(12, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 465);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // answersbtn
            // 
            this.answersbtn.Location = new System.Drawing.Point(209, 424);
            this.answersbtn.Name = "answersbtn";
            this.answersbtn.Size = new System.Drawing.Size(83, 33);
            this.answersbtn.TabIndex = 5;
            this.answersbtn.Text = "ثبت پاسخ ها";
            this.answersbtn.UseVisualStyleBackColor = true;
            this.answersbtn.Click += new System.EventHandler(this.answersbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.question2answer4);
            this.panel3.Controls.Add(this.question2answer3);
            this.panel3.Controls.Add(this.question2answer2);
            this.panel3.Controls.Add(this.question2answer1);
            this.panel3.Controls.Add(this.questionTwo);
            this.panel3.Location = new System.Drawing.Point(8, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 130);
            this.panel3.TabIndex = 4;
            // 
            // question2answer4
            // 
            this.question2answer4.AutoSize = true;
            this.question2answer4.BackColor = System.Drawing.Color.Transparent;
            this.question2answer4.ForeColor = System.Drawing.Color.White;
            this.question2answer4.Location = new System.Drawing.Point(56, 91);
            this.question2answer4.Name = "question2answer4";
            this.question2answer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question2answer4.Size = new System.Drawing.Size(122, 28);
            this.question2answer4.TabIndex = 8;
            this.question2answer4.TabStop = true;
            this.question2answer4.Text = "radioButton5";
            this.question2answer4.UseVisualStyleBackColor = false;
            // 
            // question2answer3
            // 
            this.question2answer3.AutoSize = true;
            this.question2answer3.BackColor = System.Drawing.Color.Transparent;
            this.question2answer3.ForeColor = System.Drawing.Color.White;
            this.question2answer3.Location = new System.Drawing.Point(56, 55);
            this.question2answer3.Name = "question2answer3";
            this.question2answer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question2answer3.Size = new System.Drawing.Size(121, 28);
            this.question2answer3.TabIndex = 7;
            this.question2answer3.TabStop = true;
            this.question2answer3.Text = "radioButton6";
            this.question2answer3.UseVisualStyleBackColor = false;
            // 
            // question2answer2
            // 
            this.question2answer2.AutoSize = true;
            this.question2answer2.BackColor = System.Drawing.Color.Transparent;
            this.question2answer2.ForeColor = System.Drawing.Color.White;
            this.question2answer2.Location = new System.Drawing.Point(295, 91);
            this.question2answer2.Name = "question2answer2";
            this.question2answer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question2answer2.Size = new System.Drawing.Size(122, 28);
            this.question2answer2.TabIndex = 6;
            this.question2answer2.TabStop = true;
            this.question2answer2.Text = "radioButton7";
            this.question2answer2.UseVisualStyleBackColor = false;
            // 
            // question2answer1
            // 
            this.question2answer1.AutoSize = true;
            this.question2answer1.BackColor = System.Drawing.Color.Transparent;
            this.question2answer1.ForeColor = System.Drawing.Color.White;
            this.question2answer1.Location = new System.Drawing.Point(295, 55);
            this.question2answer1.Name = "question2answer1";
            this.question2answer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question2answer1.Size = new System.Drawing.Size(122, 28);
            this.question2answer1.TabIndex = 5;
            this.question2answer1.TabStop = true;
            this.question2answer1.Text = "radioButton8";
            this.question2answer1.UseVisualStyleBackColor = false;
            // 
            // questionTwo
            // 
            this.questionTwo.BackColor = System.Drawing.Color.Transparent;
            this.questionTwo.ForeColor = System.Drawing.Color.White;
            this.questionTwo.Location = new System.Drawing.Point(16, 15);
            this.questionTwo.Name = "questionTwo";
            this.questionTwo.Size = new System.Drawing.Size(454, 27);
            this.questionTwo.TabIndex = 0;
            this.questionTwo.Text = "2.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.question3answer4);
            this.panel4.Controls.Add(this.question3answer3);
            this.panel4.Controls.Add(this.question3answer2);
            this.panel4.Controls.Add(this.question3answer1);
            this.panel4.Controls.Add(this.questionThree);
            this.panel4.Location = new System.Drawing.Point(8, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 130);
            this.panel4.TabIndex = 4;
            // 
            // question3answer4
            // 
            this.question3answer4.AutoSize = true;
            this.question3answer4.BackColor = System.Drawing.Color.Transparent;
            this.question3answer4.ForeColor = System.Drawing.Color.White;
            this.question3answer4.Location = new System.Drawing.Point(56, 91);
            this.question3answer4.Name = "question3answer4";
            this.question3answer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question3answer4.Size = new System.Drawing.Size(122, 28);
            this.question3answer4.TabIndex = 8;
            this.question3answer4.TabStop = true;
            this.question3answer4.Text = "radioButton9";
            this.question3answer4.UseVisualStyleBackColor = false;
            // 
            // question3answer3
            // 
            this.question3answer3.AutoSize = true;
            this.question3answer3.BackColor = System.Drawing.Color.Transparent;
            this.question3answer3.ForeColor = System.Drawing.Color.White;
            this.question3answer3.Location = new System.Drawing.Point(56, 55);
            this.question3answer3.Name = "question3answer3";
            this.question3answer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question3answer3.Size = new System.Drawing.Size(130, 28);
            this.question3answer3.TabIndex = 7;
            this.question3answer3.TabStop = true;
            this.question3answer3.Text = "radioButton10";
            this.question3answer3.UseVisualStyleBackColor = false;
            // 
            // question3answer2
            // 
            this.question3answer2.AutoSize = true;
            this.question3answer2.BackColor = System.Drawing.Color.Transparent;
            this.question3answer2.ForeColor = System.Drawing.Color.White;
            this.question3answer2.Location = new System.Drawing.Point(289, 91);
            this.question3answer2.Name = "question3answer2";
            this.question3answer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question3answer2.Size = new System.Drawing.Size(130, 28);
            this.question3answer2.TabIndex = 6;
            this.question3answer2.TabStop = true;
            this.question3answer2.Text = "radioButton11";
            this.question3answer2.UseVisualStyleBackColor = false;
            // 
            // question3answer1
            // 
            this.question3answer1.AutoSize = true;
            this.question3answer1.BackColor = System.Drawing.Color.Transparent;
            this.question3answer1.ForeColor = System.Drawing.Color.White;
            this.question3answer1.Location = new System.Drawing.Point(289, 55);
            this.question3answer1.Name = "question3answer1";
            this.question3answer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question3answer1.Size = new System.Drawing.Size(130, 28);
            this.question3answer1.TabIndex = 5;
            this.question3answer1.TabStop = true;
            this.question3answer1.Text = "radioButton12";
            this.question3answer1.UseVisualStyleBackColor = false;
            // 
            // questionThree
            // 
            this.questionThree.BackColor = System.Drawing.Color.Transparent;
            this.questionThree.ForeColor = System.Drawing.Color.White;
            this.questionThree.Location = new System.Drawing.Point(16, 16);
            this.questionThree.Name = "questionThree";
            this.questionThree.Size = new System.Drawing.Size(454, 26);
            this.questionThree.TabIndex = 0;
            this.questionThree.Text = "3.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.question1answer4);
            this.panel2.Controls.Add(this.question1answer3);
            this.panel2.Controls.Add(this.question1answer2);
            this.panel2.Controls.Add(this.question1answer1);
            this.panel2.Controls.Add(this.questionOne);
            this.panel2.Location = new System.Drawing.Point(8, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 130);
            this.panel2.TabIndex = 3;
            // 
            // question1answer4
            // 
            this.question1answer4.AutoSize = true;
            this.question1answer4.BackColor = System.Drawing.Color.Transparent;
            this.question1answer4.ForeColor = System.Drawing.Color.White;
            this.question1answer4.Location = new System.Drawing.Point(56, 91);
            this.question1answer4.Name = "question1answer4";
            this.question1answer4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question1answer4.Size = new System.Drawing.Size(122, 28);
            this.question1answer4.TabIndex = 4;
            this.question1answer4.TabStop = true;
            this.question1answer4.Text = "radioButton4";
            this.question1answer4.UseVisualStyleBackColor = false;
            // 
            // question1answer3
            // 
            this.question1answer3.AutoSize = true;
            this.question1answer3.BackColor = System.Drawing.Color.Transparent;
            this.question1answer3.ForeColor = System.Drawing.Color.White;
            this.question1answer3.Location = new System.Drawing.Point(56, 57);
            this.question1answer3.Name = "question1answer3";
            this.question1answer3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question1answer3.Size = new System.Drawing.Size(122, 28);
            this.question1answer3.TabIndex = 3;
            this.question1answer3.TabStop = true;
            this.question1answer3.Text = "radioButton3";
            this.question1answer3.UseVisualStyleBackColor = false;
            // 
            // question1answer2
            // 
            this.question1answer2.AutoSize = true;
            this.question1answer2.BackColor = System.Drawing.Color.Transparent;
            this.question1answer2.ForeColor = System.Drawing.Color.White;
            this.question1answer2.Location = new System.Drawing.Point(295, 91);
            this.question1answer2.Name = "question1answer2";
            this.question1answer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question1answer2.Size = new System.Drawing.Size(122, 28);
            this.question1answer2.TabIndex = 2;
            this.question1answer2.TabStop = true;
            this.question1answer2.Text = "radioButton2";
            this.question1answer2.UseVisualStyleBackColor = false;
            // 
            // question1answer1
            // 
            this.question1answer1.AutoSize = true;
            this.question1answer1.BackColor = System.Drawing.Color.Transparent;
            this.question1answer1.ForeColor = System.Drawing.Color.White;
            this.question1answer1.Location = new System.Drawing.Point(295, 57);
            this.question1answer1.Name = "question1answer1";
            this.question1answer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.question1answer1.Size = new System.Drawing.Size(122, 28);
            this.question1answer1.TabIndex = 1;
            this.question1answer1.TabStop = true;
            this.question1answer1.Text = "radioButton1";
            this.question1answer1.UseVisualStyleBackColor = false;
            // 
            // questionOne
            // 
            this.questionOne.BackColor = System.Drawing.Color.Transparent;
            this.questionOne.ForeColor = System.Drawing.Color.White;
            this.questionOne.Location = new System.Drawing.Point(16, 12);
            this.questionOne.Name = "questionOne";
            this.questionOne.Size = new System.Drawing.Size(454, 32);
            this.questionOne.TabIndex = 0;
            this.questionOne.Text = "1.";
            // 
            // ClassSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classlist);
            this.Name = "ClassSignUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت نام و تعیین سطح";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox classlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label questionOne;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label questionTwo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label questionThree;
        private System.Windows.Forms.RadioButton question1answer2;
        private System.Windows.Forms.RadioButton question1answer1;
        private System.Windows.Forms.RadioButton question2answer4;
        private System.Windows.Forms.RadioButton question2answer3;
        private System.Windows.Forms.RadioButton question2answer2;
        private System.Windows.Forms.RadioButton question2answer1;
        private System.Windows.Forms.RadioButton question3answer4;
        private System.Windows.Forms.RadioButton question3answer3;
        private System.Windows.Forms.RadioButton question3answer2;
        private System.Windows.Forms.RadioButton question3answer1;
        private System.Windows.Forms.RadioButton question1answer4;
        private System.Windows.Forms.RadioButton question1answer3;
        private System.Windows.Forms.Button answersbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label namelbl;
    }
}