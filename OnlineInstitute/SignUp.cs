using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OnlineInstitute
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(102, 154, 73);
        }
        public static string name;
        public static string password;
        public static string username;
        public static string email;
        public static string phone;
        private void submit_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && usernametxt.Text != "" && passtxt.Text != "" && emailtxt.Text != "" && phonetxt.Text != "")
            {
                name = nametxt.Text;
                username = usernametxt.Text;
                password = passtxt.Text;
                email = emailtxt.Text;
                phone = phonetxt.Text;
                if (password.Length >= 8)
                {
                    if (phone.Length == 11)
                    {
                        // CONNECT TO DATABASE
                        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OnlineInstitute.accdb");
                        con.Open();
                        
                        OleDbCommand cmdSelect = new OleDbCommand("SELECT * FROM [User] WHERE username=@username", con);
                        cmdSelect.Parameters.AddWithValue("@username", username);
                        OleDbDataReader reader = cmdSelect.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("این نام کاربری قبلا ثبت شده است!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        }
                        else
                        {//INSERT INTO QUERY
                            OleDbCommand cmd = new OleDbCommand("INSERT INTO [User] ([username], [password], [fullname], [email], [phone]) VALUES (@username, @password, @name, @email, @phone)", con);

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            publicInfo.publicUsername = username;
                            publicInfo.publicPassword = password;
                            publicInfo.publicName = name;
                            publicInfo.publicEmail = email;
                            publicInfo.publicPhone = phone;
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                //IF QUERY SUCCESSFUL
                                MessageBox.Show("ثبت نام با موفقیت انجام شد!", "ثبت نام", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

                                ClassSignUp frm = new ClassSignUp();
                                frm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                //IF QUERY FAILED
                                MessageBox.Show("خطا در ثبت نام به وجود آمده!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                            }
                        }
                    }
                    else
                    {
                        // IF PHONE NUMBER IS NOT 11 DIGITS
                        MessageBox.Show("شماره تلفن باید 11 رقم باشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                else
                {
                    //IF PASSWORD IS LESS THAN 8 CHARACTERS
                    MessageBox.Show("رمز عبور باید 8 کاراکتر یا بیشتر باشد!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            else
            {
                // IF FORM IS NOT COMPLETE
                MessageBox.Show("فرم را کامل کنید!", "فرم ناقص", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
