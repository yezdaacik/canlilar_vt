using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesli_tukenen_canlilar
{
    public partial class YeniEkleForm : Form
    {

        string baglanti = "Server=localhost;Database=sonyasamlar;Uid=root;Pwd='';";
        string yeniAd;
        public YeniEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "INSERT INTO canli VALUES(NULL, @ad ,@pop ,@ulke ,@habitat ,@gorsel);";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@ad", txtAdEkle.Text);
                cmd.Parameters.AddWithValue("@pop", txtPopEkle.Text);
                cmd.Parameters.AddWithValue("@ulke", cmbUlkeEkle.SelectedValue);
                cmd.Parameters.AddWithValue("@habitat", txtHabitatEkle.Text);
                cmd.Parameters.AddWithValue("@gorsel", yeniAd);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                }
            }
        
        }

        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT yaşadığı_ülke FROM canli;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbUlkeEkle.DataSource = dt;

                cmbUlkeEkle.DisplayMember = "yaşadığı_ülke";
                cmbUlkeEkle.ValueMember = "yaşadığı_ülke";

            }

        }

        private void pbResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "fotograf", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbResimEkle.Image = null;
            if (File.Exists(hedefDosya))
            {
                pbResimEkle.Image = Image.FromFile(hedefDosya);
                pbResimEkle.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void YeniEkleForm_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }
    }
}
