namespace TBP_projekt
{
    partial class Moje_biljke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moje_biljke));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.cmbVnazivi = new System.Windows.Forms.ComboBox();
            this.Vlaga = new System.Windows.Forms.GroupBox();
            this.btnUnesiVlagu = new System.Windows.Forms.Button();
            this.tboxVlaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Temperatura = new System.Windows.Forms.GroupBox();
            this.btnUnesiTemperaturu = new System.Windows.Forms.Button();
            this.tboxTemperatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTnazivi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Vlaga.SuspendLayout();
            this.Temperatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Povratak na Početnu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje biljke";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDodaj.Location = new System.Drawing.Point(672, 100);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(160, 33);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novu biljku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mjerenje vlage za određenu biljku:";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisi.Location = new System.Drawing.Point(672, 161);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(160, 34);
            this.btnBrisi.TabIndex = 6;
            this.btnBrisi.Text = "Obriši označenu biljku";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbVnazivi
            // 
            this.cmbVnazivi.FormattingEnabled = true;
            this.cmbVnazivi.Location = new System.Drawing.Point(14, 80);
            this.cmbVnazivi.Name = "cmbVnazivi";
            this.cmbVnazivi.Size = new System.Drawing.Size(211, 24);
            this.cmbVnazivi.TabIndex = 7;
            // 
            // Vlaga
            // 
            this.Vlaga.Controls.Add(this.btnUnesiVlagu);
            this.Vlaga.Controls.Add(this.tboxVlaga);
            this.Vlaga.Controls.Add(this.label5);
            this.Vlaga.Controls.Add(this.cmbVnazivi);
            this.Vlaga.Controls.Add(this.label3);
            this.Vlaga.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vlaga.Location = new System.Drawing.Point(456, 273);
            this.Vlaga.Name = "Vlaga";
            this.Vlaga.Size = new System.Drawing.Size(298, 292);
            this.Vlaga.TabIndex = 8;
            this.Vlaga.TabStop = false;
            this.Vlaga.Text = "Vlaga";
            // 
            // btnUnesiVlagu
            // 
            this.btnUnesiVlagu.Location = new System.Drawing.Point(71, 224);
            this.btnUnesiVlagu.Name = "btnUnesiVlagu";
            this.btnUnesiVlagu.Size = new System.Drawing.Size(109, 41);
            this.btnUnesiVlagu.TabIndex = 12;
            this.btnUnesiVlagu.Text = "Unesi vlagu";
            this.btnUnesiVlagu.UseVisualStyleBackColor = true;
            this.btnUnesiVlagu.Click += new System.EventHandler(this.btnUnesiVlagu_Click);
            // 
            // tboxVlaga
            // 
            this.tboxVlaga.Location = new System.Drawing.Point(20, 173);
            this.tboxVlaga.Name = "tboxVlaga";
            this.tboxVlaga.Size = new System.Drawing.Size(199, 24);
            this.tboxVlaga.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unesite izmjerenu vlagu ( u %) :";
            // 
            // Temperatura
            // 
            this.Temperatura.Controls.Add(this.btnUnesiTemperaturu);
            this.Temperatura.Controls.Add(this.tboxTemperatura);
            this.Temperatura.Controls.Add(this.label2);
            this.Temperatura.Controls.Add(this.cmbTnazivi);
            this.Temperatura.Controls.Add(this.label4);
            this.Temperatura.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatura.Location = new System.Drawing.Point(39, 267);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(262, 298);
            this.Temperatura.TabIndex = 9;
            this.Temperatura.TabStop = false;
            this.Temperatura.Text = "Temperatura";
            // 
            // btnUnesiTemperaturu
            // 
            this.btnUnesiTemperaturu.Location = new System.Drawing.Point(65, 230);
            this.btnUnesiTemperaturu.Name = "btnUnesiTemperaturu";
            this.btnUnesiTemperaturu.Size = new System.Drawing.Size(109, 41);
            this.btnUnesiTemperaturu.TabIndex = 10;
            this.btnUnesiTemperaturu.Text = "Unesi temperaturu";
            this.btnUnesiTemperaturu.UseVisualStyleBackColor = true;
            this.btnUnesiTemperaturu.Click += new System.EventHandler(this.btnUnesiTemperaturu_Click);
            // 
            // tboxTemperatura
            // 
            this.tboxTemperatura.Location = new System.Drawing.Point(23, 179);
            this.tboxTemperatura.Name = "tboxTemperatura";
            this.tboxTemperatura.Size = new System.Drawing.Size(199, 24);
            this.tboxTemperatura.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Unesite izmjerenu temperaturu:";
            // 
            // cmbTnazivi
            // 
            this.cmbTnazivi.FormattingEnabled = true;
            this.cmbTnazivi.Location = new System.Drawing.Point(23, 74);
            this.cmbTnazivi.Name = "cmbTnazivi";
            this.cmbTnazivi.Size = new System.Drawing.Size(199, 24);
            this.cmbTnazivi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mjerenje temperature u prostoriji";
            // 
            // Moje_biljke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(860, 627);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.Vlaga);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Moje_biljke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moje biljke";
            this.Load += new System.EventHandler(this.Moje_biljke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Vlaga.ResumeLayout(false);
            this.Vlaga.PerformLayout();
            this.Temperatura.ResumeLayout(false);
            this.Temperatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.ComboBox cmbVnazivi;
        private System.Windows.Forms.GroupBox Vlaga;
        private System.Windows.Forms.GroupBox Temperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnesiVlagu;
        private System.Windows.Forms.TextBox tboxVlaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnesiTemperaturu;
        private System.Windows.Forms.TextBox tboxTemperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTnazivi;
    }
}