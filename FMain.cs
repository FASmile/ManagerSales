using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectNhom
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProjectNhom.FManagerEmployees fME = new FManagerEmployees();
            fME.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form fCust = new Form();


            DataGridView dataGridView = new DataGridView();
            dataGridView.Width = fCust.Width;
            dataGridView.Height = fCust.Height;
            dataGridView.Left = 0;
            dataGridView.Top = 0;
            dataGridView.ColumnCount = 3;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns[0].Name = "CustID";
            dataGridView.Columns[1].Name = "Ordermonth";
            dataGridView.Columns[2].Name = "qty";
            
            fCust.Controls.Add(dataGridView);
            string kn = @"server=.\sqlexpress;database=TSQLFundamentals2008;integrated security=true";
            string sSql = "SELECT O.custid, DATEADD(month, DATEDIFF(month, 0, O.orderdate), 0) AS ordermonth, SUM(OD.qty) AS qty FROM Sales.Orders AS O INNER JOIN Sales.OrderDetails AS OD ON OD.orderid = O.orderid GROUP BY O.custid, DATEADD(month, DATEDIFF(month, 0, O.orderdate), 0)";
            //khai báo 1 biến kết nối đến CSDL
            SqlConnection con = new SqlConnection(kn);
            //mở kết nối
            con.Open();
            //khai báo 1 biến thực hiện lệnh trong SQl
            SqlCommand cmd = new SqlCommand();
            //kết nối biến đến CSDL
            cmd.Connection = con;
            //gán lệnh SQL cho biến
            cmd.CommandText = sSql;
            //khai báo 1 biến để nạp dữ liệu từ SQL
            SqlDataAdapter da = new SqlDataAdapter(sSql, con);
            //khai báo 1 biến chứa dữ liệu dạng bảng
            DataTable db = new DataTable();
            //nạp dữ liệu từ SQl vào biến chứa dữ liệu
            da.Fill(db);
            //đưa dữ liệu ra datagridview
            dataGridView.DataSource = db;
            //ngắt kết nối
            con.Dispose();
            da.Dispose();
            cmd.Dispose();

            fCust.ShowDialog();
        }
    }
}
