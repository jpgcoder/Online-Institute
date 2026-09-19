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
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace OnlineInstitute
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(102, 154, 73);
        }
        public static string username;
        public static string password;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text != "" && passtxt.Text != "")
            {
                // IF FORM IS COMPLETE
                username = usernametxt.Text;
                password = passtxt.Text;
                // CONNECT TO DATABASE
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OnlineInstitute.accdb");
                con.Open();
                //QUERY
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [User] WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // IF USER EXISTS
                    MessageBox.Show("ورود موفقیت آمیز بود!", "ورود", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    publicInfo.publicUsername = reader["username"].ToString();
                    publicInfo.publicPassword = reader["password"].ToString();
                    publicInfo.publicName = reader["fullname"].ToString();
                    publicInfo.publicEmail = reader["email"].ToString();
                    publicInfo.publicPhone = reader["phone"].ToString();
                    ClassSignUp frm = new ClassSignUp();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    // IF USER DOESN'T EXIST
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            else
            {
                // IF FORM IS NOT COMPLETE
                MessageBox.Show("فرم را کامل کنید!", "فرم ناقص", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
        }
    }
    
}
