using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AntivirusSimulator
{
    public partial class FrmAntivirus : Form
    {
        string secilenKlasor = "";
        string karantinaKlasoru = "";

        // Şüpheli uzantılar (imza tabanlı)
        string[] supheliUzantilar = { ".exe", ".bat", ".vbs", ".cmd", ".scr" };

        // Şüpheli kelimeler (heuristic)
        string[] supheliKelimeler = { "virus", "trojan", "keygen", "crack", "hack" };

        public FrmAntivirus()
        {
            InitializeComponent();
        }

        // ================= KLASÖR SEÇ =================
        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                secilenKlasor = folderBrowserDialog1.SelectedPath;
                karantinaKlasoru = Path.Combine(secilenKlasor, "Karantina");

                if (!Directory.Exists(karantinaKlasoru))
                    Directory.CreateDirectory(karantinaKlasoru);

                MessageBox.Show("Klasör seçildi:\n" + secilenKlasor);
            }
        }

        // ================= TARAMA =================
        private void btnTara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenKlasor))
            {
                MessageBox.Show("Önce klasör seç!");
                return;
            }

            listViewDosyalar.Items.Clear();

            string[] dosyalar = Directory.GetFiles(secilenKlasor);
            progressBar1.Maximum = dosyalar.Length;
            progressBar1.Value = 0;

            foreach (string dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileName(dosya);
                string uzanti = Path.GetExtension(dosya).ToLower();

                bool supheliMi = false;

                // Uzanti kontrolü
                if (supheliUzantilar.Contains(uzanti))
                    supheliMi = true;

                // Kelime kontrolü
                foreach (string kelime in supheliKelimeler)
                {
                    if (dosyaAdi.ToLower().Contains(kelime))
                    {
                        supheliMi = true;
                        break;
                    }
                }

                string durum = supheliMi ? "ŞÜPHELİ" : "Temiz";

                ListViewItem item = new ListViewItem(dosyaAdi);
                item.SubItems.Add(durum);

                if (supheliMi)
                    item.BackColor = System.Drawing.Color.LightCoral;

                listViewDosyalar.Items.Add(item);

                LogYaz(dosyaAdi + " → " + durum);

                progressBar1.Value++;
            }

            MessageBox.Show("Tarama tamamlandı");
        }

        // ================= KARANTİNA =================
        private void btnKarantina_Click(object sender, EventArgs e)
        {
            if (listViewDosyalar.Items.Count == 0)
            {
                MessageBox.Show("Önce tarama yap!");
                return;
            }

            foreach (ListViewItem item in listViewDosyalar.Items)
            {
                if (item.SubItems[1].Text == "ŞÜPHELİ")
                {
                    string kaynak = Path.Combine(secilenKlasor, item.Text);
                    string hedef = Path.Combine(karantinaKlasoru, item.Text);

                    if (File.Exists(kaynak))
                    {
                        File.Move(kaynak, hedef);
                        LogYaz(item.Text + " → KARANTİNAYA ALINDI");
                    }
                }
            }

            MessageBox.Show("Şüpheli dosyalar karantinaya alındı");
            listViewDosyalar.Items.Clear();
        }

        // ================= LOG =================
        void LogYaz(string mesaj)
        {
            string logYolu = Path.Combine(Application.StartupPath, "log.txt");
            File.AppendAllText(logYolu,
                DateTime.Now + " - " + mesaj + Environment.NewLine);
        }
    }
}

