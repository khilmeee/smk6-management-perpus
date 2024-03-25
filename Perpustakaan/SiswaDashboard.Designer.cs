namespace Perpustakaan
{
    partial class SiswaDashboard
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
            this.button_historyBuku = new System.Windows.Forms.Button();
            this.button_pinjamBuku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Logout);
            this.panel1.Controls.Add(this.button_historyBuku);
            this.panel1.Controls.Add(this.button_pinjamBuku);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 450);
            this.panel1.TabIndex = 2;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(127, 45);
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
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "as Siswa";
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
            // button_historyBuku
            // 
            this.button_historyBuku.BackColor = System.Drawing.Color.AliceBlue;
            this.button_historyBuku.FlatAppearance.BorderSize = 0;
            this.button_historyBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_historyBuku.Location = new System.Drawing.Point(3, 121);
            this.button_historyBuku.Name = "button_historyBuku";
            this.button_historyBuku.Size = new System.Drawing.Size(183, 49);
            this.button_historyBuku.TabIndex = 1;
            this.button_historyBuku.Text = "History Peminjaman\r\n";
            this.button_historyBuku.UseVisualStyleBackColor = false;
            this.button_historyBuku.Click += new System.EventHandler(this.button_historyBuku_Click);
            // 
            // button_pinjamBuku
            // 
            this.button_pinjamBuku.BackColor = System.Drawing.Color.AliceBlue;
            this.button_pinjamBuku.FlatAppearance.BorderSize = 0;
            this.button_pinjamBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pinjamBuku.Location = new System.Drawing.Point(3, 66);
            this.button_pinjamBuku.Name = "button_pinjamBuku";
            this.button_pinjamBuku.Size = new System.Drawing.Size(183, 49);
            this.button_pinjamBuku.TabIndex = 0;
            this.button_pinjamBuku.Text = "Pinjam Buku";
            this.button_pinjamBuku.UseVisualStyleBackColor = false;
            this.button_pinjamBuku.Click += new System.EventHandler(this.button_pinjamBuku_Click);
            // 
            // SiswaDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SiswaDashboard";
            this.Text = "SiswaDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_historyBuku;
        private System.Windows.Forms.Button button_pinjamBuku;
    }
}