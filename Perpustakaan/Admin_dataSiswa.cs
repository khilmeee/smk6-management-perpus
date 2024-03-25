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

namespace Perpustakaan
{
    public partial class Admin_dataSiswa : UserControl
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public int id_siswa;
        public int id_login;

        public Admin_dataSiswa()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = $"SELECT * FROM siswa INNER JOIN login ON siswa.id_login = login.id_login";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "NIS";
                dataGridView1.Columns[2].HeaderText = "Nama";
                dataGridView1.Columns[3].HeaderText = "Kelas";
                dataGridView1.Columns[4].HeaderText = "Alamat";
                dataGridView1.Columns[5].HeaderText = "NoTelp";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].HeaderText = "Username";
                dataGridView1.Columns[9].HeaderText = "Password";
                dataGridView1.Columns[10].Visible = false;

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error:" + ex);
            }
        }
    }
}
