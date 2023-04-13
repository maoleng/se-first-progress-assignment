using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT1_CNPM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iUsername.Text == "admin" && iPassword.Text == "123456")
            {
                var form = new MainForm();
                this.Hide();
                form.Show();
            } else
            {
                MessageBox.Show("Wrong username or password");
            }
            
        }
    }
}
