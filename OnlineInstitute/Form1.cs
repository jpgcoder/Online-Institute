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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.ShowDialog();

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void viewclassesbtn_Click(object sender, EventArgs e)
        {
            Classes frm= new Classes();
            frm.ShowDialog();
        }
    }
    public static class publicInfo
    {
        public static string publicUsername;
        public static string publicPassword;
        public static string publicName;
        public static string publicEmail;
        public static string publicPhone;
    }
    public static class classes
    {
        public static string publicClass;
        public static string publicLvl;
    }
}
