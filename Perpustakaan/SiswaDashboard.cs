using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class SiswaDashboard : Form
    {
        public SiswaDashboard()
        {
            InitializeComponent();
            label_username.Text = $"({GlobalVar.username})";
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
        }

        private void button_pinjamBuku_Click(object sender, EventArgs e)
        {
            Siswa_pinjamBuku menu = this.Controls.OfType<Siswa_pinjamBuku>().FirstOrDefault();
            if (menu == null)
            {
                menu = new Siswa_pinjamBuku();
                menu.Dock = DockStyle.Fill;
                this.Controls.Add(menu);
            }
            menu.BringToFront();
        }

        private void button_historyBuku_Click(object sender, EventArgs e)
        {
            Siswa_historyPeminjaman menu = this.Controls.OfType<Siswa_historyPeminjaman>().FirstOrDefault();
            if (menu == null)
            {
                menu = new Siswa_historyPeminjaman();
                menu.Dock = DockStyle.Fill;
                this.Controls.Add(menu);
            }
            menu.BringToFront();
        }
    }
}
