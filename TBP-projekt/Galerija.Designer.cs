namespace TBP_projekt
{
    partial class Galerija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galerija));
            this.label1 = new System.Windows.Forms.Label();
            this.btnZalijevanje = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pBoxSlika = new System.Windows.Forms.PictureBox();
            this.tBoxOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxNaziv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDatumsadnje = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgGalerija = new System.Windows.Forms.DataGridView();
            this.pBoxPrikazSlike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSlika)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGalerija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrikazSlike)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Galerija";
            // 
            // btnZalijevanje
            // 
            this.btnZalijevanje.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZalijevanje.Location = new System.Drawing.Point(44, 29);
            this.btnZalijevanje.Name = "btnZalijevanje";
            this.btnZalijevanje.Size = new System.Drawing.Size(168, 48);
            this.btnZalijevanje.TabIndex = 1;
            this.btnZalijevanje.Text = "Povratak na Početnu";
            this.btnZalijevanje.UseVisualStyleBackColor = true;
            this.btnZalijevanje.Click += new System.EventHandler(this.btnZalijevanje_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberi.Location = new System.Drawing.Point(236, 380);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(201, 31);
            this.btnOdaberi.TabIndex = 2;
            this.btnOdaberi.Text = "Odaberi fotografiju";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dodavanje nove fotografije";
            // 
            // pBoxSlika
            // 
            this.pBoxSlika.Location = new System.Drawing.Point(60, 317);
            this.pBoxSlika.Name = "pBoxSlika";
            this.pBoxSlika.Size = new System.Drawing.Size(162, 154);
            this.pBoxSlika.TabIndex = 5;
            this.pBoxSlika.TabStop = false;
            // 
            // tBoxOpis
            // 
            this.tBoxOpis.Location = new System.Drawing.Point(117, 488);
            this.tBoxOpis.Name = "tBoxOpis";
            this.tBoxOpis.Size = new System.Drawing.Size(251, 20);
            this.tBoxOpis.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis:";
            // 
            // tBoxNaziv
            // 
            this.tBoxNaziv.Location = new System.Drawing.Point(59, 120);
            this.tBoxNaziv.Name = "tBoxNaziv";
            this.tBoxNaziv.Size = new System.Drawing.Size(226, 20);
            this.tBoxNaziv.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pretraži biljku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDatumsadnje);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji o biljci";
            // 
            // labelDatumsadnje
            // 
            this.labelDatumsadnje.AutoSize = true;
            this.labelDatumsadnje.Location = new System.Drawing.Point(220, 35);
            this.labelDatumsadnje.Name = "labelDatumsadnje";
            this.labelDatumsadnje.Size = new System.Drawing.Size(42, 16);
            this.labelDatumsadnje.TabIndex = 3;
            this.labelDatumsadnje.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Datum sadnje:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(43, 35);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 16);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(184, 539);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi ";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgGalerija
            // 
            this.dgGalerija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGalerija.Location = new System.Drawing.Point(497, 131);
            this.dgGalerija.Name = "dgGalerija";
            this.dgGalerija.Size = new System.Drawing.Size(442, 150);
            this.dgGalerija.TabIndex = 12;
            // 
            // pBoxPrikazSlike
            // 
            this.pBoxPrikazSlike.Location = new System.Drawing.Point(497, 299);
            this.pBoxPrikazSlike.Name = "pBoxPrikazSlike";
            this.pBoxPrikazSlike.Size = new System.Drawing.Size(442, 284);
            this.pBoxPrikazSlike.TabIndex = 13;
            this.pBoxPrikazSlike.TabStop = false;
            // 
            // Galerija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 595);
            this.Controls.Add(this.pBoxPrikazSlike);
            this.Controls.Add(this.dgGalerija);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxOpis);
            this.Controls.Add(this.pBoxSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnZalijevanje);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Galerija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galerija";
            this.Load += new System.EventHandler(this.Galerija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSlika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGalerija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPrikazSlike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZalijevanje;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pBoxSlika;
        private System.Windows.Forms.TextBox tBoxOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxNaziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDatumsadnje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgGalerija;
        private System.Windows.Forms.PictureBox pBoxPrikazSlike;
    }
}