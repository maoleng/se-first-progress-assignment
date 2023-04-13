using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QT1_CNPM
{
    public partial class ManageItemForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public ManageItemForm()
        {
            InitializeComponent();
        }
        private void ManageItemForm_Load(object sender, EventArgs e)
        {
            string sql = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            this.cn = new SqlConnection(sql);
            this.cn.Open();

            fillDataGrid("SELECT * FROM Item");
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            string name = iItemName.Text;
            string size = iItemSize.Text;
            string price = iItemPrice.Text;
            executeSql($"INSERT INTO Item (ItemName, Size, Price) VALUES ('{name}', '{size}', {price})");

            MessageBox.Show("Create successfully");
            fillDataGrid("SELECT * FROM Item");
        }


        void fillDataGrid(string sql)
        {
            this.data = new SqlDataAdapter(sql, this.cn);
            tb = new DataTable();
            this.data.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        void executeSql(string sql)
        {
            SqlCommand query = new SqlCommand(sql, this.cn);
            query.ExecuteNonQuery();
        }

        
    }
}
