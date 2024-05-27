namespace nesli_tukenen_canlilar
{
    partial class YeniEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdEkle = new System.Windows.Forms.TextBox();
            this.txtPopEkle = new System.Windows.Forms.TextBox();
            this.txtHabitatEkle = new System.Windows.Forms.TextBox();
            this.cmbUlkeEkle = new System.Windows.Forms.ComboBox();
            this.pbResimEkle = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canlı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yasadığı Ülke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Populasyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Habitat";
            // 
            // txtAdEkle
            // 
            this.txtAdEkle.Location = new System.Drawing.Point(101, 11);
            this.txtAdEkle.Name = "txtAdEkle";
            this.txtAdEkle.Size = new System.Drawing.Size(121, 20);
            this.txtAdEkle.TabIndex = 4;
            // 
            // txtPopEkle
            // 
            this.txtPopEkle.Location = new System.Drawing.Point(101, 82);
            this.txtPopEkle.Name = "txtPopEkle";
            this.txtPopEkle.Size = new System.Drawing.Size(121, 20);
            this.txtPopEkle.TabIndex = 6;
            // 
            // txtHabitatEkle
            // 
            this.txtHabitatEkle.Location = new System.Drawing.Point(101, 117);
            this.txtHabitatEkle.Name = "txtHabitatEkle";
            this.txtHabitatEkle.Size = new System.Drawing.Size(121, 20);
            this.txtHabitatEkle.TabIndex = 7;
            // 
            // cmbUlkeEkle
            // 
            this.cmbUlkeEkle.FormattingEnabled = true;
            this.cmbUlkeEkle.Location = new System.Drawing.Point(101, 45);
            this.cmbUlkeEkle.Name = "cmbUlkeEkle";
            this.cmbUlkeEkle.Size = new System.Drawing.Size(121, 21);
            this.cmbUlkeEkle.TabIndex = 8;
            // 
            // pbResimEkle
            // 
            this.pbResimEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbResimEkle.Location = new System.Drawing.Point(292, 11);
            this.pbResimEkle.Name = "pbResimEkle";
            this.pbResimEkle.Size = new System.Drawing.Size(148, 201);
            this.pbResimEkle.TabIndex = 9;
            this.pbResimEkle.TabStop = false;
            this.pbResimEkle.Click += new System.EventHandler(this.pbResimEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(101, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 51);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // YeniEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 243);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pbResimEkle);
            this.Controls.Add(this.cmbUlkeEkle);
            this.Controls.Add(this.txtHabitatEkle);
            this.Controls.Add(this.txtPopEkle);
            this.Controls.Add(this.txtAdEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniEkleForm";
            this.Text = "YeniEkleForm";
            this.Load += new System.EventHandler(this.YeniEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdEkle;
        private System.Windows.Forms.TextBox txtPopEkle;
        private System.Windows.Forms.TextBox txtHabitatEkle;
        private System.Windows.Forms.ComboBox cmbUlkeEkle;
        private System.Windows.Forms.PictureBox pbResimEkle;
        private System.Windows.Forms.Button btnEkle;
    }
}