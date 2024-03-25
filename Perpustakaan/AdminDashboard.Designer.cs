namespace Perpustakaan
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_dataPetugas = new System.Windows.Forms.Button();
            this.button_dataBuku = new System.Windows.Forms.Button();
            this.button_dataSiswa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Logout);
            this.panel1.Controls.Add(this.button_dataPetugas);
            this.panel1.Controls.Add(this.button_dataBuku);
            this.panel1.Controls.Add(this.button_dataSiswa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 450);
            this.panel1.TabIndex = 1;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(120, 45);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(35, 13);
            this.label_username.TabIndex = 7;
            this.label_username.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "as Admin";
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Location = new System.Drawing.Point(3, 341);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(183, 49);
            this.button_Logout.TabIndex = 5;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // button_dataPetugas
            // 
            this.button_dataPetugas.BackColor = System.Drawing.Color.AliceBlue;
            this.button_dataPetugas.FlatAppearance.BorderSize = 0;
            this.button_dataPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataPetugas.Location = new System.Drawing.Point(3, 176);
            this.button_dataPetugas.Name = "button_dataPetugas";
            this.button_dataPetugas.Size = new System.Drawing.Size(183, 49);
            this.button_dataPetugas.TabIndex = 2;
            this.button_dataPetugas.Text = "Data Petugas";
            this.button_dataPetugas.UseVisualStyleBackColor = false;
            this.button_dataPetugas.Click += new System.EventHandler(this.button_dataPetugas_Click);
            // 
            // button_dataBuku
            // 
            this.button_dataBuku.BackColor = System.Drawing.Color.AliceBlue;
            this.button_dataBuku.FlatAppearance.BorderSize = 0;
            this.button_dataBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataBuku.Location = new System.Drawing.Point(3, 121);
            this.button_dataBuku.Name = "button_dataBuku";
            this.button_dataBuku.Size = new System.Drawing.Size(183, 49);
            this.button_dataBuku.TabIndex = 1;
            this.button_dataBuku.Text = "Data Buku";
            this.button_dataBuku.UseVisualStyleBackColor = false;
            this.button_dataBuku.Click += new System.EventHandler(this.button_dataBuku_Click);
            // 
            // button_dataSiswa
            // 
            this.button_dataSiswa.BackColor = System.Drawing.Color.AliceBlue;
            this.button_dataSiswa.FlatAppearance.BorderSize = 0;
            this.button_dataSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataSiswa.Location = new System.Drawing.Point(3, 66);
            this.button_dataSiswa.Name = "button_dataSiswa";
            this.button_dataSiswa.Size = new System.Drawing.Size(183, 49);
            this.button_dataSiswa.TabIndex = 0;
            this.button_dataSiswa.Text = "Data Siswa";
            this.button_dataSiswa.UseVisualStyleBackColor = false;
            this.button_dataSiswa.Click += new System.EventHandler(this.button_dataSiswa_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_dataPetugas;
        private System.Windows.Forms.Button button_dataBuku;
        private System.Windows.Forms.Button button_dataSiswa;
    }
}