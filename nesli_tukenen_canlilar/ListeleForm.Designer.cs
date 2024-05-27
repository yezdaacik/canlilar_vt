namespace nesli_tukenen_canlilar
{
    partial class ListeleForm
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
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwCanlilar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanlilar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(298, 19);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(115, 179);
            this.pbResim.TabIndex = 19;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(107, 53);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(121, 21);
            this.cmbUlke.TabIndex = 18;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(107, 140);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(121, 20);
            this.txtHabitat.TabIndex = 17;
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(107, 97);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(121, 20);
            this.txtPop.TabIndex = 16;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 20);
            this.txtAd.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Habitat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Populasyon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yasadığı Ülke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Canlı Adı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(449, 85);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 51);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(449, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 51);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwCanlilar
            // 
            this.dgwCanlilar.AllowUserToAddRows = false;
            this.dgwCanlilar.AllowUserToDeleteRows = false;
            this.dgwCanlilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCanlilar.Location = new System.Drawing.Point(13, 270);
            this.dgwCanlilar.Name = "dgwCanlilar";
            this.dgwCanlilar.ReadOnly = true;
            this.dgwCanlilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCanlilar.Size = new System.Drawing.Size(666, 209);
            this.dgwCanlilar.TabIndex = 23;
            this.dgwCanlilar.SelectionChanged += new System.EventHandler(this.dgwCanlilar_SelectionChanged);
            // 
            // ListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 491);
            this.Controls.Add(this.dgwCanlilar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cmbUlke);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListeleForm";
            this.Text = "ListeleForm";
            this.Load += new System.EventHandler(this.ListeleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanlilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwCanlilar;
    }
}