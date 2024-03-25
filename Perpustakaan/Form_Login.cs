using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Form_Login : Form
    {
        public SqlConnection connection = new SqlConnection(konek.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = $"SELECT * FROM login WHERE username = '{textBox_username.Text}' AND password = '{textBox_password.Text}'";
            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if(tabel.Rows.Count > 0)
            {
                foreach(DataRow dr in tabel.Rows)
                {
                    if (dr["level"].ToString() == "admin")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        GlobalVar.username = reader.GetString(1);

                        this.Hide();
                        AdminDashboard panggil = new AdminDashboard();
                        panggil.Show();
                    }
                    else if (dr["level"].ToString() == "petugas")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        GlobalVar.username = reader.GetString(1);

                        this.Hide();
                        PetugasDashboard panggil = new PetugasDashboard();
                        panggil.Show();
                    }
                    else if (dr["level"].ToString() == "siswa")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        GlobalVar.username = reader.GetString(1);

                        this.Hide();
                        SiswaDashboard panggil = new SiswaDashboard();
                        panggil.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("invalid login");
            }
            connection.Close();
        }
    }
}
