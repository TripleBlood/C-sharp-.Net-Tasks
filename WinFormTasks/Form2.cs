using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTasks
{
    public partial class Form2 : Form
    {

        DataSet dataset = new DataSet();
        SqlDataAdapter adapter;
        DBConnection connection = new DBConnection();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "Select * from spell";
            //String sql2 = "insert into spell(name, damage, damage_type) values ('Ice lance', 40, 'ICE')";

            SqlConnection con = new SqlConnection(connection.Con);
            //SqlCommand cmd = new SqlCommand("Command String", con);
            if (con.State == ConnectionState.Closed) con.Open();

            //Верхние штуки подключаются к БД
            adapter = new SqlDataAdapter(sql, con);

            var commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataset.Tables[0];

            //SqlCommand command = new SqlCommand(sql2, con);
            //command.ExecuteNonQuery();

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells[1].Value) == "Ice lance") row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
        

        private void IceLanceGridDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Red) dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void colorizeSelected_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Selected == true) row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            dataset.Clear();
            adapter.Fill(dataset);
            dataGridView1.Refresh();
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void delFromDb_Click(object sender, EventArgs e)
        {
            List<int> idBuffer = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    idBuffer.Add(Convert.ToInt32(row.Cells[0].Value));
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }

            if (idBuffer.Count > 0)
            {
                SqlConnection con = new SqlConnection(connection.Con);
                if (con.State == ConnectionState.Closed) con.Open();

                foreach (int id in idBuffer)
                {
                    SqlCommand command = new SqlCommand("delete from spell where ID = " + id + " ;", con);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
