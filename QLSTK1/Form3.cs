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
    public partial class Form3 : Form
    {
        public Form3()
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
            command.CommandText = "insert into PHIEURUTTIEN values('" + textMaso.Text + "',N'" + textKhachhang.Text + "','" + dateTimePicker.Text + "'," + textTien.Text + ")";
            int flag = command.ExecuteNonQuery();
            if (flag >= 1)
            {
                MessageBox.Show("Lập phiếu thành công.");
            }
            connection.Close();
        }
    }
}
