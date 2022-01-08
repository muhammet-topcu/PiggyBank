
namespace kumbaraa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcb_para = new System.Windows.Forms.PictureBox();
            this.btn_paraekle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_calkala = new System.Windows.Forms.Button();
            this.btn_kır = new System.Windows.Forms.Button();
            this.btn_yapıstır = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Zaman = new System.Windows.Forms.Timer(this.components);
            this.lbl_paragırısı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_para)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_para
            // 
            this.pcb_para.Location = new System.Drawing.Point(665, 73);
            this.pcb_para.Margin = new System.Windows.Forms.Padding(4);
            this.pcb_para.Name = "pcb_para";
            this.pcb_para.Size = new System.Drawing.Size(80, 79);
            this.pcb_para.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_para.TabIndex = 1;
            this.pcb_para.TabStop = false;
            // 
            // btn_paraekle
            // 
            this.btn_paraekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_paraekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paraekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paraekle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_paraekle.Location = new System.Drawing.Point(28, 149);
            this.btn_paraekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paraekle.Name = "btn_paraekle";
            this.btn_paraekle.Size = new System.Drawing.Size(265, 49);
            this.btn_paraekle.TabIndex = 2;
            this.btn_paraekle.Text = "Para Ekle";
            this.btn_paraekle.UseVisualStyleBackColor = false;
            this.btn_paraekle.Click += new System.EventHandler(this.btn_paraekle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 88);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleName = "Doluluk Oranı";
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(914, 38);
            this.progressBar1.TabIndex = 4;
            // 
            // btn_calkala
            // 
            this.btn_calkala.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_calkala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calkala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_calkala.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_calkala.Location = new System.Drawing.Point(28, 221);
            this.btn_calkala.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calkala.Name = "btn_calkala";
            this.btn_calkala.Size = new System.Drawing.Size(265, 58);
            this.btn_calkala.TabIndex = 5;
            this.btn_calkala.Text = "Kumbarayı Çalkala";
            this.btn_calkala.UseVisualStyleBackColor = false;
            this.btn_calkala.Click += new System.EventHandler(this.btn_calkala_Click);
            // 
            // btn_kır
            // 
            this.btn_kır.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kır.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_kır.Location = new System.Drawing.Point(28, 303);
            this.btn_kır.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kır.Name = "btn_kır";
            this.btn_kır.Size = new System.Drawing.Size(265, 59);
            this.btn_kır.TabIndex = 6;
            this.btn_kır.Text = "Kumbarayı Kır";
            this.btn_kır.UseVisualStyleBackColor = false;
            this.btn_kır.Click += new System.EventHandler(this.btn_kır_Click);
            // 
            // btn_yapıstır
            // 
            this.btn_yapıstır.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_yapıstır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yapıstır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yapıstır.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_yapıstır.Location = new System.Drawing.Point(28, 383);
            this.btn_yapıstır.Margin = new System.Windows.Forms.Padding(4);
            this.btn_yapıstır.Name = "btn_yapıstır";
            this.btn_yapıstır.Size = new System.Drawing.Size(265, 59);
            this.btn_yapıstır.TabIndex = 7;
            this.btn_yapıstır.Text = "Kumbarayı Yapıştır";
            this.btn_yapıstır.UseVisualStyleBackColor = false;
            this.btn_yapıstır.Click += new System.EventHandler(this.btn_yapıstır_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(302, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kumbara Doluluk Oranı";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.BackColor = System.Drawing.Color.Snow;
            this.lbl_toplam.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_toplam.Location = new System.Drawing.Point(396, 471);
            this.lbl_toplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(117, 38);
            this.lbl_toplam.TabIndex = 9;
            this.lbl_toplam.Text = "Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 518);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 11;
            // 
            // lbl_paragırısı
            // 
            this.lbl_paragırısı.AutoSize = true;
            this.lbl_paragırısı.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_paragırısı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_paragırısı.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paragırısı.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_paragırısı.Location = new System.Drawing.Point(661, 230);
            this.lbl_paragırısı.Name = "lbl_paragırısı";
            this.lbl_paragırısı.Size = new System.Drawing.Size(84, 20);
            this.lbl_paragırısı.TabIndex = 12;
            this.lbl_paragırısı.Text = "Para Girişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 535);
            this.Controls.Add(this.lbl_paragırısı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yapıstır);
            this.Controls.Add(this.btn_kır);
            this.Controls.Add(this.btn_calkala);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_paraekle);
            this.Controls.Add(this.pcb_para);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_para)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_para;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_paraekle;
        private System.Windows.Forms.Button btn_calkala;
        private System.Windows.Forms.Button btn_kır;
        private System.Windows.Forms.Button btn_yapıstır;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Zaman;
        private System.Windows.Forms.Label lbl_paragırısı;
    }
}

