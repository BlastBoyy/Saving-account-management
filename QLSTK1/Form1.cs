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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        string connectStr = @"Data Source=LAPTOP-9VMFMRRH\SQLEXPRESS;Initial Catalog=QLSTK;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectStr);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();
            command.CommandText = "insert into SOTIETKIEM values('" + textMaso.Text + "',N'" + textKhachhang.Text + "',N'" + textDiachi.Text + "'," + textTien.Text + ",N'" + comboLoaiTK.Text + "',N'" + textCMND.Text + "','" + dateTimePicker.Text + "','" + dateTimePicker.Text + "','OPEN')";
            int flag = command.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBox.Show("Mở sổ thành công.");
            }
            connection.Close();
        }
    }
}
