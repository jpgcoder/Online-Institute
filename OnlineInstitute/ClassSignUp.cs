using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineInstitute
{
    public partial class ClassSignUp : Form
    {
        public static string lvl = "";
        public static string chosenclass = "";
        public ClassSignUp()
        {
            InitializeComponent();
            namelbl.Text = "";
            usernamelbl.Text = "";
            namelbl.Text = publicInfo.publicName;
            usernamelbl.Text = publicInfo.publicUsername;

            // سوال اول
            questionOne.Text = "1.";
            question1answer1.Text = "";
            question1answer2.Text = "";
            question1answer3.Text = "";
            question1answer4.Text = "";

            //سوال دوم
            questionTwo.Text = "2.";
            question2answer1.Text = "";
            question2answer2.Text = "";
            question2answer3.Text = "";
            question2answer4.Text = "";

            //سوال سوم
            questionThree.Text = "3.";
            question3answer1.Text = "";
            question3answer2.Text = "";
            question3answer3.Text = "";
            question3answer4.Text = "";
        }

        private void answersbtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (question1answer2.Checked)
            {
                i++;
            }
            if (question2answer2.Checked)
            {
                i++;
            }
            if (question3answer2.Checked)
            {
                i++;
            }
            switch (i)
            {
                case 0:
                    lvl = "تازه کار";
                    break;
                case 1:
                    lvl = "مبتدی";
                    break;
                case 2:
                    lvl = "متوسط";
                    break;
                case 3:
                    lvl = "حرفه ای";
                    break;
            }
            chosenclass = classlist.SelectedItem.ToString();
            classes.publicClass = chosenclass;
            classes.publicLvl = lvl;
            MessageBox.Show(lvl,"سطح شما",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            this.Close();
            FinalForm frm= new FinalForm();
            frm.ShowDialog();
            
        }

        private void classlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (classlist.SelectedItem == "زبان انگلیسی")
            {
                panel1.RightToLeft = RightToLeft.No;
                // سوال اول
                questionOne.Text = "1.What is the plural form of book?";
                question1answer1.Text = "bookes";
                question1answer2.Text = "books";
                question1answer3.Text = "bookies";
                question1answer4.Text = "book's";

                //سوال دوم
                questionTwo.Text = "2.Which word is a verb?";
                question2answer1.Text = "apple";
                question2answer2.Text = "run";
                question2answer3.Text = "blue";
                question2answer4.Text = "happy";

                //سوال سوم
                questionThree.Text = "3.Choose the correct 'present' sentence";
                question3answer1.Text = "She go to school";
                question3answer2.Text = "She goes to school";
                question3answer3.Text = "She going to school";
                question3answer4.Text = "She gone to school";

            }
            else if (classlist.SelectedItem == "زبان آلمانی")
            {
                panel1.RightToLeft = RightToLeft.No;

                // سوال اول
                questionOne.Text = "1.Was bedeutet \"Guten Morgen\" auf Persisch?";
                question1answer1.Text = "شب به خیر";
                question1answer2.Text = "صبح به خیر";
                question1answer3.Text = "سلام";
                question1answer4.Text = "خداحافظ";

                //سوال دوم
                questionTwo.Text = "2.Welcher Artikel ist richtig für das Wort \"Tisch\"?";
                question2answer1.Text = "die";
                question2answer2.Text = "der";
                question2answer3.Text = "das";
                question2answer4.Text = "den";

                //سوال سوم
                questionThree.Text = "3.Was ist die Zahl \"vier\"";
                question3answer1.Text = "2";
                question3answer2.Text = "4";
                question3answer3.Text = "3";
                question3answer4.Text = "5";
            }
            else if (classlist.SelectedItem == "زبان ترکی")
            {
                panel1.RightToLeft = RightToLeft.No;

                // سوال اول
                questionOne.Text = "1.\"Merhaba\" ne anlama gelir?";
                question1answer1.Text = "خداحافظ";
                question1answer2.Text = "سلام";
                question1answer3.Text = "روز خوش";
                question1answer4.Text = "شب به خیر";

                //سوال دوم
                questionTwo.Text = "2.halgisi bir renktir?";
                question2answer1.Text = "kedi";
                question2answer2.Text = "mavi";
                question2answer3.Text = "kalen";
                question2answer4.Text = "masa";

                //سوال سوم
                questionThree.Text = "3.\"ben\" zamiri ne anlama geliri";
                question3answer1.Text = "تو";
                question3answer2.Text = "من";
                question3answer3.Text = "او";
                question3answer4.Text = "ما";
            }
            else if (classlist.SelectedItem == "پایتون")
            {
                panel1.RightToLeft = RightToLeft.Yes;

                // سوال اول
                questionOne.Text = "1.خروجی print(2+3*4) چیست؟";
                question1answer1.Text = "20";
                question1answer2.Text = "14";
                question1answer3.Text = "24";
                question1answer4.Text = "10";

                //سوال دوم
                questionTwo.Text = "2.برای دریافت ورودی از کاربر در پایتون از کدام تابع استفاده می شود؟";
                question2answer1.Text = "get()";
                question2answer2.Text = "input()";
                question2answer3.Text = "scan()";
                question2answer4.Text = "read()";

                //سوال سوم
                questionThree.Text = "3.کدام یک از گزینه های زیر list را در پایتون ایجاد می کند؟";
                question3answer1.Text = "(3,2,1)";
                question3answer2.Text = "[3,2,1]";
                question3answer3.Text = "{3,2,1}";
                question3answer4.Text = "\"3,2,1\"";
            }
            else if (classlist.SelectedItem == "سی شارپ")
            {
                panel1.RightToLeft = RightToLeft.Yes;

                // سوال اول
                questionOne.Text = "1.خروجی Console.WriteLine(2+3*5) چیست؟";
                question1answer1.Text = "25";
                question1answer2.Text = "17";
                question1answer3.Text = "15";
                question1answer4.Text = "21";

                //سوال دوم
                questionTwo.Text = "2.کدام گزینه برای تعریف متغیر عدد صحیح است؟";
                question2answer1.Text = "int x = \"10\"";
                question2answer2.Text = "int x = 10";
                question2answer3.Text = "string x = 10";
                question2answer4.Text = "float x = \"10.0\"";

                //سوال سوم
                questionThree.Text = "3.برای دریافت ورودی از کاربر از کدام تابع استفاده می شود؟";
                question3answer1.Text = "Console.ReadKey()";
                question3answer2.Text = "Console.ReadLine()";
                question3answer3.Text = "input()";
                question3answer4.Text = "get()";
            }
        }
    }
    
}
