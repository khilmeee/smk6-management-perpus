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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
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

        private void button_dataSiswa_Click(object sender, EventArgs e)
        {
            Admin_dataSiswa dataSiswaMenu = this.Controls.OfType<Admin_dataSiswa>().FirstOrDefault();
            if(dataSiswaMenu == null)
            {
                dataSiswaMenu = new Admin_dataSiswa();
                dataSiswaMenu.Dock = DockStyle.Fill; 
                this.Controls.Add(dataSiswaMenu);
            }
            dataSiswaMenu.BringToFront();
        }

        private void button_dataBuku_Click(object sender, EventArgs e)
        {
            Admin_dataBuku dataBukuMenu = this.Controls.OfType<Admin_dataBuku>().FirstOrDefault();
            if (dataBukuMenu == null)
            {
                dataBukuMenu = new Admin_dataBuku();
                dataBukuMenu.Dock = DockStyle.Fill;
                this.Controls.Add(dataBukuMenu);
            }
            dataBukuMenu.BringToFront();
        }

        private void button_dataPetugas_Click(object sender, EventArgs e)
        {
            Admin_dataPetugas menu = this.Controls.OfType<Admin_dataPetugas>().FirstOrDefault();
            if (menu == null)
            {
                menu = new Admin_dataPetugas();
                menu.Dock = DockStyle.Fill;
                this.Controls.Add(menu);
            }
            menu.BringToFront();
        }
    }
}
