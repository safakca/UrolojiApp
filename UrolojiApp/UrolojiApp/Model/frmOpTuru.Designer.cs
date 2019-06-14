namespace UrolojiApp.Model
{
    partial class frmOpTuru
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
            this.txtOpTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.clbListe = new System.Windows.Forms.CheckedListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.txtOpTuru);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(348, 100);
            this.pnlUst.TabIndex = 0;
            // 
            // txtOpTuru
            // 
            this.txtOpTuru.Location = new System.Drawing.Point(127, 51);
            this.txtOpTuru.Name = "txtOpTuru";
            this.txtOpTuru.Size = new System.Drawing.Size(171, 20);
            this.txtOpTuru.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operasyon Türü :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(348, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pnlOrta
            // 
            this.pnlOrta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlOrta.Controls.Add(this.splitContainer1);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 100);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(348, 192);
            this.pnlOrta.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbListe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAktar);
            this.splitContainer1.Size = new System.Drawing.Size(348, 192);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // clbListe
            // 
            this.clbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbListe.FormattingEnabled = true;
            this.clbListe.Location = new System.Drawing.Point(0, 0);
            this.clbListe.Name = "clbListe";
            this.clbListe.Size = new System.Drawing.Size(242, 188);
            this.clbListe.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAktar.Font = new System.Drawing.Font("Papyrus", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktar.Location = new System.Drawing.Point(0, 0);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(94, 188);
            this.btnAktar.TabIndex = 0;
            this.btnAktar.Text = "AKTAR";
            this.btnAktar.UseVisualStyleBackColor = true;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAlt.Controls.Add(this.btnKapat);
            this.pnlAlt.Controls.Add(this.btnSil);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 292);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(348, 100);
            this.pnlAlt.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Location = new System.Drawing.Point(0, 77);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(348, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(348, 23);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // frmOpTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 392);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.pnlAlt);
            this.Name = "frmOpTuru";
            this.Text = "frmOpTuru";
            this.Load += new System.EventHandler(this.frmOpTuru_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.pnlOrta.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAlt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckedListBox clbListe;
        private System.Windows.Forms.Button btnAktar;
        internal System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtOpTuru;
        private System.Windows.Forms.Label label1;
    }
}