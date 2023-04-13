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
    public partial class FilterForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            string sql = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            this.cn = new SqlConnection(sql);
            this.cn.Open();
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

        private void button1_Click(object sender, EventArgs e)
        {
            fillDataGrid("SELECT * FROM \"Agent\"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillDataGrid("SELECT * FROM \"Item\"");
        }

        private void btnFilterItem_Click(object sender, EventArgs e)
        {
            int agent_id = Int16.Parse(iAgentId.Text);
            fillDataGrid($"SELECT item.* , agentname AS \"Customer Name\"\r\nFROM item\r\nLEFT JOIN orderdetail ON  orderdetail.itemid = item.itemid\r\nLEFT JOIN \"order\" on \"order\".orderid = orderdetail.orderid\r\nLEFT JOIN agent on \"order\".agentid = agent.agentid\r\nWHERE agent.agentid = {agent_id}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int item_id = Int16.Parse(iItemId.Text);
            fillDataGrid($"SELECT distinct agent.*, item.ItemName AS \"Item Name\"\r\nFROM agent\r\nLEFT JOIN \"order\" on \"order\".agentid = agent.agentid\r\nLEFT JOIN orderdetail ON  orderdetail.orderid = \"order\".orderid\r\nLEFT JOIN item on item.itemid = orderdetail.itemid\r\nWHERE item.itemid = {item_id}");
        }
    }
}
