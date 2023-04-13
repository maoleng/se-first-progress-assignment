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
    public partial class OrderForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            int order_id = Int16.Parse(iOrderId.Text);
            fillDataGrid($"SELECT \"ORDER\".orderid AS \"Order ID\", item.ItemName AS \"Item Name\", quantity, price\r\nFROM \"ORDER\" \r\nLEFT JOIN orderdetail ON orderdetail.OrderID = \"ORDER\".OrderID \r\nLEFT JOIN item ON item.itemid = orderdetail.itemid\r\nWHERE \"order\".orderid = {order_id}");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            string sql = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            this.cn = new SqlConnection(sql);
            this.cn.Open();

            fillDataGrid("SELECT * FROM \"Order\"");
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
