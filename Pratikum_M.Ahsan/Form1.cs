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
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace Pratikum_M.Ahsan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNisn.Text == string.Empty || txtNama.Text == string.Empty || txtAlamat.Text == string.Empty || txtNoHp.Text == string.Empty)
            {
                MessageBox.Show("Isi dengan Lengkap");
            }
            else
            {
                table.Rows.Add(txtNisn.Text, txtNama.Text, comboBox1.Text, comboBox2.Text,txtAlamat.Text, txtNoHp.Text);
                dataGridView1.DataSource = table;
            }
        }
        DataTable table = new DataTable();
        private void Home_Load(object sender, EventArgs e)
        {
            table.Columns.Add("NISN", typeof(int));
            table.Columns.Add("Nama", typeof(string));
            table.Columns.Add("Kelas", typeof(string));
            table.Columns.Add("Jurusan", typeof(string)); 
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("No.Hp", typeof(string));

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtNisn.Text = selectedRow.Cells[0].Value.ToString();
            txtNama.Text = selectedRow.Cells[1].Value.ToString();
            comboBox1.Text = selectedRow.Cells[2].Value.ToString();
            comboBox2.Text = selectedRow.Cells[3].Value.ToString();
            txtAlamat.Text = selectedRow.Cells[4].Value.ToString();
            txtNoHp.Text = selectedRow.Cells[5].Value.ToString();
        }
    }
}
