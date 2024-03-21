namespace Uygulama22
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYazarı = new System.Windows.Forms.TextBox();
            this.txtKitapTürü = new System.Windows.Forms.TextBox();
            this.btnKitapekle = new System.Windows.Forms.Button();
            this.listeVeri = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Türü";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(149, 72);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 3;
            // 
            // txtKitapYazarı
            // 
            this.txtKitapYazarı.Location = new System.Drawing.Point(149, 115);
            this.txtKitapYazarı.Name = "txtKitapYazarı";
            this.txtKitapYazarı.Size = new System.Drawing.Size(100, 20);
            this.txtKitapYazarı.TabIndex = 4;
            // 
            // txtKitapTürü
            // 
            this.txtKitapTürü.Location = new System.Drawing.Point(149, 152);
            this.txtKitapTürü.Name = "txtKitapTürü";
            this.txtKitapTürü.Size = new System.Drawing.Size(100, 20);
            this.txtKitapTürü.TabIndex = 5;
            // 
            // btnKitapekle
            // 
            this.btnKitapekle.Location = new System.Drawing.Point(173, 193);
            this.btnKitapekle.Name = "btnKitapekle";
            this.btnKitapekle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapekle.TabIndex = 6;
            this.btnKitapekle.Text = "Kitap Ekle";
            this.btnKitapekle.UseVisualStyleBackColor = true;
            this.btnKitapekle.Click += new System.EventHandler(this.btnKitapekle_Click);
            // 
            // listeVeri
            // 
            this.listeVeri.FormattingEnabled = true;
            this.listeVeri.Location = new System.Drawing.Point(348, 72);
            this.listeVeri.Name = "listeVeri";
            this.listeVeri.Size = new System.Drawing.Size(269, 108);
            this.listeVeri.TabIndex = 7;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(542, 193);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listeVeri);
            this.Controls.Add(this.btnKitapekle);
            this.Controls.Add(this.txtKitapTürü);
            this.Controls.Add(this.txtKitapYazarı);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYazarı;
        private System.Windows.Forms.TextBox txtKitapTürü;
        private System.Windows.Forms.Button btnKitapekle;
        private System.Windows.Forms.ListBox listeVeri;
        private System.Windows.Forms.Button btnListele;
    }
}

