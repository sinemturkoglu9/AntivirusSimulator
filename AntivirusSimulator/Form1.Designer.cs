namespace AntivirusSimulator
{
    partial class FrmAntivirus
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKlasorSec = new System.Windows.Forms.Button();
            this.btnTara = new System.Windows.Forms.Button();
            this.btnKarantina = new System.Windows.Forms.Button();
            this.listViewDosyalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnKlasorSec
            // 
            this.btnKlasorSec.Location = new System.Drawing.Point(20, 20);
            this.btnKlasorSec.Name = "btnKlasorSec";
            this.btnKlasorSec.Size = new System.Drawing.Size(120, 35);
            this.btnKlasorSec.TabIndex = 0;
            this.btnKlasorSec.Text = "Klasör Seç";
            this.btnKlasorSec.UseVisualStyleBackColor = true;
            this.btnKlasorSec.Click += new System.EventHandler(this.btnKlasorSec_Click);
            // 
            // btnTara
            // 
            this.btnTara.Location = new System.Drawing.Point(160, 20);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(120, 35);
            this.btnTara.TabIndex = 1;
            this.btnTara.Text = "Tara";
            this.btnTara.UseVisualStyleBackColor = true;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // btnKarantina
            // 
            this.btnKarantina.Location = new System.Drawing.Point(300, 20);
            this.btnKarantina.Name = "btnKarantina";
            this.btnKarantina.Size = new System.Drawing.Size(140, 35);
            this.btnKarantina.TabIndex = 2;
            this.btnKarantina.Text = "Karantinaya Al";
            this.btnKarantina.UseVisualStyleBackColor = true;
            this.btnKarantina.Click += new System.EventHandler(this.btnKarantina_Click);
            // 
            // listViewDosyalar
            // 
            this.listViewDosyalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDosyalar.FullRowSelect = true;
            this.listViewDosyalar.GridLines = true;
            this.listViewDosyalar.HideSelection = false;
            this.listViewDosyalar.Location = new System.Drawing.Point(20, 70);
            this.listViewDosyalar.Name = "listViewDosyalar";
            this.listViewDosyalar.Size = new System.Drawing.Size(840, 300);
            this.listViewDosyalar.TabIndex = 3;
            this.listViewDosyalar.UseCompatibleStateImageBehavior = false;
            this.listViewDosyalar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dosya Adı";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Durum";
            this.columnHeader2.Width = 150;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 390);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(840, 25);
            this.progressBar1.TabIndex = 4;
            // 
            // FrmAntivirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listViewDosyalar);
            this.Controls.Add(this.btnKarantina);
            this.Controls.Add(this.btnTara);
            this.Controls.Add(this.btnKlasorSec);
            this.Name = "FrmAntivirus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antivirus Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorSec;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.Button btnKarantina;
        private System.Windows.Forms.ListView listViewDosyalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

