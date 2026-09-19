using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineInstitute
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(102, 154, 73);
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            namelbl.Text = "نام و نام خانوادگی: " + publicInfo.publicName;
            emaillbl.Text = "ایمیل: " + publicInfo.publicEmail;
            phonelbl.Text = "تلفن: " + publicInfo.publicPhone;
            classlbl.Text = "کلاس: " + classes.publicClass;
            levellbl.Text = "سطح: " + classes.publicLvl;
            pricelbl.Text = "قیمت: ";
            if (classes.publicClass == "زبان انگلیسی")
            {
                pricelbl.Text += "1200000";
            }
            else if (classes.publicClass == "زبان آلمانی")
            {
                pricelbl.Text += "1800000";
            }
            else if (classes.publicClass == "زبان ترکی")
            {
                pricelbl.Text += "1500000";
            }
            else if (classes.publicClass == "پایتون")
            {
                pricelbl.Text += "1400000";
            }
            else if (classes.publicClass == "سی شارپ")
            {
                pricelbl.Text += "1100000";
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            ClassSignUp frm= new ClassSignUp();
            frm.ShowDialog();
            this.Close();
        }

        private void finalize_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OnlineInstitute.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO [class] ([username], [class], [level]) VALUES (@username, @class, @level)", con);
            cmd.Parameters.AddWithValue("@username", publicInfo.publicUsername);
            cmd.Parameters.AddWithValue("@class", classes.publicClass);
            cmd.Parameters.AddWithValue("@level", classes.publicLvl);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("ثبت نام در کلاس نهایی شد!", "ثبت نام", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                this.Close();
            }
        }
    }
}
