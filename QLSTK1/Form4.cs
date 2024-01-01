using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiSoTietKiem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        string connectStr = @"Data Source=LAPTOP-9VMFMRRH\SQLEXPRESS;Initial Catalog=QLSTK;Integrated Security=True";

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectStr);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();
            string myCommandText = "select MASO, LOAITK, TENKH from SOTIETKIEM where STATUS = 'OPEN'";
            if (textMaso.Text != "")
            {
                myCommandText = myCommandText + " and MASO = '" + textMaso.Text + "'";
            }
            if (comboLoaiTK.Text != "")
            {
                myCommandText = myCommandText + " and LOAITK = N'" + comboLoaiTK.Text + "'";
            }
            if (textKhachhang.Text != "")
            {
                myCommandText = myCommandText + " and TENKH = N'" + textKhachhang.Text + "'";
            }
            command.CommandText = myCommandText;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            DataTraCuu.DataSource = table;
            connection.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectStr);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();
            command.CommandText = "select LOAITK from LOAITIETKIEM";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                comboLoaiTK.Items.Add(row[0]);
            }
            connection.Close();
        }
    }
}
