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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        string connectStr = @"Data Source=LAPTOP-9VMFMRRH\SQLEXPRESS;Initial Catalog=QLSTK;Integrated Security=True";

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectStr);
            connection.Open();
            SqlCommand command;
            command = connection.CreateCommand();
            string myCommandText = "select NGAYMOSO as Ngày, count(MASO) as Sổ_mở from SOTIETKIEM where STATUS = 'OPEN'";
            if (comboLoaiTK.Text != "")
            {
                myCommandText = myCommandText + " and LOAITK = N'" + comboLoaiTK.Text + "'";
            }
            if (dateTimePicker.Text != "")
            {
                myCommandText = myCommandText + " and MONTH(NGAYMOSO) = MONTH('" + dateTimePicker.Text + "') and YEAR(NGAYMOSO) = YEAR('" + dateTimePicker.Text + "')";
            }
            myCommandText += " group by NGAYMOSO";
            command.CommandText = myCommandText;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dataSomo.DataSource = table;
            //
            SqlCommand command2;
            command2 = connection.CreateCommand();
            string myCommandText2 = "select NGAYCAPNHAT as Ngày, count(MASO) as Sổ_đóng from SOTIETKIEM where STATUS = 'CLOSE'";
            if (comboLoaiTK.Text != "")
            {
                myCommandText2 = myCommandText2 + " and LOAITK = N'" + comboLoaiTK.Text + "'";
            }
            if (dateTimePicker.Text != "")
            {
                myCommandText2 = myCommandText2 + " and MONTH(NGAYCAPNHAT) = MONTH('" + dateTimePicker.Text + "') and YEAR(NGAYCAPNHAT) = YEAR('" + dateTimePicker.Text + "')";
            }
            myCommandText2 += " group by NGAYCAPNHAT";
            command2.CommandText = myCommandText2;
            SqlDataAdapter adapter2;
            adapter2 = new SqlDataAdapter();
            adapter2.SelectCommand = command2;
            DataTable table2 = new DataTable();
            table2.Clear();
            adapter2.Fill(table2);
            dataSodong.DataSource = table2;
            connection.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
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
