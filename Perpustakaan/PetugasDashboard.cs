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
    public partial class PetugasDashboard : Form
    {
        public PetugasDashboard()
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

        private void button_dataPeminjaman_Click(object sender, EventArgs e)
        {
            Petugas_dataPeminjaman menu = this.Controls.OfType<Petugas_dataPeminjaman>().FirstOrDefault();
            if (menu == null)
            {
                menu = new Petugas_dataPeminjaman();
                menu.Dock = DockStyle.Fill;
                this.Controls.Add(menu);
            }
            menu.BringToFront();
        }

        private void button_dataPengembalian_Click(object sender, EventArgs e)
        {
            Petugas_dataPengembalian menu = this.Controls.OfType<Petugas_dataPengembalian>().FirstOrDefault();
            if (menu == null)
            {
                menu = new Petugas_dataPengembalian();
                menu.Dock = DockStyle.Fill;
                this.Controls.Add(menu);
            }
            menu.BringToFront();
        }
    }
}
