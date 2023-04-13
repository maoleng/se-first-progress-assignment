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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form = new ManageItemForm();
            form.ShowDialog();
        }

        private void buttonAgent_Click(object sender, EventArgs e)
        {
            var form = new ManageAgentForm();
            form.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var form = new OrderForm();
            form.ShowDialog();
        }
    }
}
