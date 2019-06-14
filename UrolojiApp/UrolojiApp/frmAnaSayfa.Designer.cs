namespace UrolojiApp
{
    partial class frmAnaSayfa
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUc = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.gbSol = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnHastaBul = new System.Windows.Forms.Button();
            this.btnHastaGiris = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.gbSol.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnUc);
            this.pnlUst.Controls.Add(this.btnIki);
            this.pnlUst.Controls.Add(this.btnBir);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(518, 54);
            this.pnlUst.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(431, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUc
            // 
            this.btnUc.Location = new System.Drawing.Point(174, 12);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(75, 23);
            this.btnUc.TabIndex = 4;
            this.btnUc.Text = "Uc";
            this.btnUc.UseVisualStyleBackColor = true;
            this.btnUc.Click += new System.EventHandler(this.btnUc_Click);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(93, 12);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(75, 23);
            this.btnIki.TabIndex = 3;
            this.btnIki.Text = "Bilgi Giris";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnBir
            // 
            this.btnBir.Location = new System.Drawing.Point(12, 12);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(75, 23);
            this.btnBir.TabIndex = 2;
            this.btnBir.Text = "Böbrek";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // gbSol
            // 
            this.gbSol.BackColor = System.Drawing.Color.Silver;
            this.gbSol.Controls.Add(this.pnl3);
            this.gbSol.Controls.Add(this.pnl2);
            this.gbSol.Controls.Add(this.pnl1);
            this.gbSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSol.Location = new System.Drawing.Point(0, 54);
            this.gbSol.Name = "gbSol";
            this.gbSol.Size = new System.Drawing.Size(98, 275);
            this.gbSol.TabIndex = 1;
            this.gbSol.TabStop = false;
            this.gbSol.Text = "groupBox1";
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl3.Location = new System.Drawing.Point(189, 16);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(93, 256);
            this.pnl3.TabIndex = 1;
            this.pnl3.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl2.Location = new System.Drawing.Point(96, 16);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(93, 256);
            this.pnl2.TabIndex = 1;
            this.pnl2.Visible = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl1.Controls.Add(this.btnHastaBul);
            this.pnl1.Controls.Add(this.btnHastaGiris);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl1.Location = new System.Drawing.Point(3, 16);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(93, 256);
            this.pnl1.TabIndex = 0;
            // 
            // btnHastaBul
            // 
            this.btnHastaBul.Location = new System.Drawing.Point(10, 53);
            this.btnHastaBul.Name = "btnHastaBul";
            this.btnHastaBul.Size = new System.Drawing.Size(75, 23);
            this.btnHastaBul.TabIndex = 1;
            this.btnHastaBul.Text = "Hasta Bul";
            this.btnHastaBul.UseVisualStyleBackColor = true;
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.Location = new System.Drawing.Point(10, 24);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGiris.TabIndex = 0;
            this.btnHastaGiris.Text = "Hasta Giris";
            this.btnHastaGiris.UseVisualStyleBackColor = true;
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 329);
            this.Controls.Add(this.gbSol);
            this.Controls.Add(this.pnlUst);
            this.IsMdiContainer = true;
            this.Name = "frmAnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.pnlUst.ResumeLayout(false);
            this.gbSol.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.GroupBox gbSol;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnUc;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnHastaBul;
        private System.Windows.Forms.Button btnHastaGiris;
    }
}

