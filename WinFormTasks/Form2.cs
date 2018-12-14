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

        private void reloadDataset()
        {
            dataset.Clear();
            adapter.Fill(dataset);
            dataGridView1.Refresh();
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload.Enabled = true;
            delColorizedFromGrid.Enabled = true;
            colorizeSelected.Enabled = true;
            delFromDb.Enabled = true;

            spellNameTextBox.Enabled = true;
            damageTextBox.Enabled = true;
            DamageTypeComboBox.Enabled = true;
            insertNewSpellInDB.Enabled = true;

            sortBySpellName.Enabled = true;
            sortByDamageType.Enabled = true;
            sortByDamage.Enabled = true;

            typeSortComboBox.Enabled = true;
            typeSortComboBoxSelect.Enabled = true;

            button1.Enabled = false;

            String sql = "Select * from spell";

            SqlConnection con = new SqlConnection(connection.Con);
            if (con.State == ConnectionState.Closed) con.Open();
            adapter = new SqlDataAdapter(sql, con);

            adapter.Fill(dataset);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataset.Tables[0];

            //SqlCommand command = new SqlCommand(sql2, con);
            //command.ExecuteNonQuery();

            con.Close();

        }
        
        private void delColorizedFromGrid_Click(object sender, EventArgs e)
        {
            List<int> indexBuffer = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    indexBuffer.Add(row.Index);
                }
            }
            for(int i = indexBuffer.Count-1 ; i >= 0; i--)
            {
                dataGridView1.Rows.RemoveAt(indexBuffer[i]);
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
            reloadDataset();
        }

        private void delFromDb_Click(object sender, EventArgs e)
        {
            List<int> idBuffer = new List<int>();
            List<int> indexBuffer = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.Red)
                {
                    idBuffer.Add(Convert.ToInt32(row.Cells[0].Value));
                    indexBuffer.Add(row.Index);
                }
            }

            if (idBuffer.Count > 0)
            {
                SqlConnection con = new SqlConnection(connection.Con);
                if (con.State == ConnectionState.Closed) con.Open();

                for (int i = indexBuffer.Count - 1; i >= 0; i--)
                {
                    dataGridView1.Rows.RemoveAt(indexBuffer[i]);
                }
                foreach (int id in idBuffer)
                {
                    SqlCommand command = new SqlCommand("delete from spell where ID = " + id + " ;", con);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void insertNewSpellInDB_Click(object sender, EventArgs e)
        {
            String sqlQueryString = "insert into spell(name, damage, damage_type) values ('" + spellNameTextBox.Text + "', " + damageTextBox.Text + ", '" + DamageTypeComboBox.Text + "');";

            int n;
            bool isNumeric = int.TryParse(damageTextBox.Text, out n);

            if (spellNameTextBox.Text != "" && damageTextBox.Text != "" && DamageTypeComboBox.Text != "" && isNumeric)
            {
                SqlConnection con = new SqlConnection(connection.Con);
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand command = new SqlCommand(sqlQueryString, con);
                command.ExecuteNonQuery();
                con.Close();
                reloadDataset();
            }
            else MessageBox.Show("Something is wrong...");            
        }
    }
}
