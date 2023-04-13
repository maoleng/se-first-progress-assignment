using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QT1_CNPM
{
    public partial class ManageAgentForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public ManageAgentForm()
        {
            InitializeComponent();
        }

        private void ManageAgentForm_Load(object sender, EventArgs e)
        {
            string sql = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            this.cn = new SqlConnection(sql);
            this.cn.Open();

            fillDataGrid("SELECT * FROM Agent");

        }

        void fillDataGrid(string sql)
        {
            this.data = new SqlDataAdapter(sql, this.cn);
            tb = new DataTable();
            this.data.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        private void btnAgentAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
