
namespace kumbaraa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pcb_yapısıkKumbara = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_paraEkle = new System.Windows.Forms.Button();
            this.btn_KumbarayıCalkala = new System.Windows.Forms.Button();
            this.btn_kumbarayıKır = new System.Windows.Forms.Button();
            this.btn_yapistir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.pcb_pararesim = new System.Windows.Forms.PictureBox();
            this.lbl_paragirisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_yapısıkKumbara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pararesim)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_yapısıkKumbara
            // 
            this.pcb_yapısıkKumbara.Image = ((System.Drawing.Image)(resources.GetObject("pcb_yapısıkKumbara.Image")));
            this.pcb_yapısıkKumbara.Location = new System.Drawing.Point(611, 267);
            this.pcb_yapısıkKumbara.Name = "pcb_yapısıkKumbara";
            this.pcb_yapısıkKumbara.Size = new System.Drawing.Size(326, 303);
            this.pcb_yapısıkKumbara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_yapısıkKumbara.TabIndex = 0;
            this.pcb_yapısıkKumbara.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_paraEkle
            // 
            this.btn_paraEkle.BackColor = System.Drawing.SystemColors.Window;
            this.btn_paraEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paraEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_paraEkle.ImageKey = "(none)";
            this.btn_paraEkle.Location = new System.Drawing.Point(41, 180);
            this.btn_paraEkle.Name = "btn_paraEkle";
            this.btn_paraEkle.Size = new System.Drawing.Size(285, 63);
            this.btn_paraEkle.TabIndex = 2;
            this.btn_paraEkle.Text = "Para Ekle";
            this.btn_paraEkle.UseVisualStyleBackColor = false;
            this.btn_paraEkle.Click += new System.EventHandler(this.btn_paraEkle_Click);
            // 
            // btn_KumbarayıCalkala
            // 
            this.btn_KumbarayıCalkala.BackColor = System.Drawing.SystemColors.Window;
            this.btn_KumbarayıCalkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KumbarayıCalkala.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_KumbarayıCalkala.Location = new System.Drawing.Point(41, 267);
            this.btn_KumbarayıCalkala.Name = "btn_KumbarayıCalkala";
            this.btn_KumbarayıCalkala.Size = new System.Drawing.Size(285, 70);
            this.btn_KumbarayıCalkala.TabIndex = 3;
            this.btn_KumbarayıCalkala.Text = "Kumbarayı Çalkala";
            this.btn_KumbarayıCalkala.UseVisualStyleBackColor = false;
            this.btn_KumbarayıCalkala.Click += new System.EventHandler(this.btn_KumbarayıCalkala_Click);
            // 
            // btn_kumbarayıKır
            // 
            this.btn_kumbarayıKır.BackColor = System.Drawing.SystemColors.Window;
            this.btn_kumbarayıKır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kumbarayıKır.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_kumbarayıKır.Location = new System.Drawing.Point(41, 361);
            this.btn_kumbarayıKır.Name = "btn_kumbarayıKır";
            this.btn_kumbarayıKır.Size = new System.Drawing.Size(285, 64);
            this.btn_kumbarayıKır.TabIndex = 4;
            this.btn_kumbarayıKır.Text = "Kumbarayı Kır";
            this.btn_kumbarayıKır.UseVisualStyleBackColor = false;
            this.btn_kumbarayıKır.Click += new System.EventHandler(this.btn_kumbarayıKır_Click);
            // 
            // btn_yapistir
            // 
            this.btn_yapistir.BackColor = System.Drawing.SystemColors.Window;
            this.btn_yapistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yapistir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_yapistir.Location = new System.Drawing.Point(41, 448);
            this.btn_yapistir.Name = "btn_yapistir";
            this.btn_yapistir.Size = new System.Drawing.Size(285, 62);
            this.btn_yapistir.TabIndex = 5;
            this.btn_yapistir.Text = "Kumbarayı Yapıştır";
            this.btn_yapistir.UseVisualStyleBackColor = false;
            this.btn_yapistir.Click += new System.EventHandler(this.btn_yapistir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(978, 39);
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kumbara Doluluk Oranı";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(381, 538);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(98, 32);
            this.lbl_toplam.TabIndex = 8;
            this.lbl_toplam.Text = "Toplam";
            // 
            // pcb_pararesim
            // 
            this.pcb_pararesim.Location = new System.Drawing.Point(726, 90);
            this.pcb_pararesim.Name = "pcb_pararesim";
            this.pcb_pararesim.Size = new System.Drawing.Size(100, 94);
            this.pcb_pararesim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_pararesim.TabIndex = 9;
            this.pcb_pararesim.TabStop = false;
            // 
            // lbl_paragirisi
            // 
            this.lbl_paragirisi.AutoSize = true;
            this.lbl_paragirisi.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paragirisi.ForeColor = System.Drawing.Color.HotPink;
            this.lbl_paragirisi.Location = new System.Drawing.Point(722, 244);
            this.lbl_paragirisi.Name = "lbl_paragirisi";
            this.lbl_paragirisi.Size = new System.Drawing.Size(104, 20);
            this.lbl_paragirisi.TabIndex = 10;
            this.lbl_paragirisi.Text = "Para Girişi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.Controls.Add(this.lbl_paragirisi);
            this.Controls.Add(this.pcb_pararesim);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_yapistir);
            this.Controls.Add(this.btn_kumbarayıKır);
            this.Controls.Add(this.btn_KumbarayıCalkala);
            this.Controls.Add(this.btn_paraEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pcb_yapısıkKumbara);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_yapısıkKumbara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pararesim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_yapısıkKumbara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_paraEkle;
        private System.Windows.Forms.Button btn_KumbarayıCalkala;
        private System.Windows.Forms.Button btn_kumbarayıKır;
        private System.Windows.Forms.Button btn_yapistir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.PictureBox pcb_pararesim;
        private System.Windows.Forms.Label lbl_paragirisi;
    }
}