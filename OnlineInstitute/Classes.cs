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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.ShowDialog();
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
            this.Close();
        }
    }
}
