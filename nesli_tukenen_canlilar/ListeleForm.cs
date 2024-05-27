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
    public partial class ListeleForm : Form
    {

        string baglanti = "Server=localhost;Database=sonyasamlar;Uid=root;Pwd='';";
        string yeniAd;
        public ListeleForm()
        {
            InitializeComponent();
        }

        private void dgwCanlilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCanlilar.SelectedRows.Count > 0)
            {
                txtAd.Text = dgwCanlilar.SelectedRows[0].Cells["ad"].Value.ToString();
                txtPop.Text = dgwCanlilar.SelectedRows[0].Cells["popülasyon"].Value.ToString();
                txtHabitat.Text = dgwCanlilar.SelectedRows[0].Cells["habitat"].Value.ToString();
                cmbUlke.SelectedValue = dgwCanlilar.SelectedRows[0].Cells["yaşadığı_ülke"].Value.ToString();

                string dosyaYolu = Path.Combine(Environment.CurrentDirectory, "fotograf", dgwCanlilar.SelectedRows[0].Cells["gorsel"].Value.ToString());

                pbResim.Image = null;
                if (File.Exists(dosyaYolu))
                {
                    pbResim.Image = Image.FromFile(dosyaYolu);
                    pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }
        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM canli;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwCanlilar.DataSource = dt;

            }
        }

        private void ListeleForm_Load(object sender, EventArgs e)
        {
            DgwDoldur();
            CmbDoldur();
       
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
                cmbUlke.DataSource = dt;

                cmbUlke.DisplayMember = "yaşadığı_ülke";
                cmbUlke.ValueMember = "yaşadığı_ülke";

            }

      
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {

                baglan.Open();
                string sorgu = "UPDATE canli SET ad=@ad, yaşadığı_ülke = @yaşadığı_ülke,  gorsel=@gorsel, popülasyon = @popülasyon  , habitat = @habitat WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@yaşadığı_ülke", cmbUlke.SelectedValue);
                cmd.Parameters.AddWithValue("@habitat", txtHabitat.Text);
                cmd.Parameters.AddWithValue("@popülasyon", txtPop.Text);
                cmd.Parameters.AddWithValue("@gorsel", yeniAd);

                int id = Convert.ToInt32(dgwCanlilar.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fotograf", yeniAd);

                cmd.ExecuteNonQuery();
                DgwDoldur();

            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "fotograf", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbResim.Image = null;
            if (File.Exists(hedefDosya))
            {
                pbResim.Image = Image.FromFile(hedefDosya);
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwCanlilar.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Kayıtı silmek istediğinizden emin misiniz?",
                                                 "Kayıtı sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int hid = Convert.ToInt32(dgwCanlilar.SelectedRows[0].Cells["id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM canli WHERE id=@id;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@id", hid);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
        }
    }


}
