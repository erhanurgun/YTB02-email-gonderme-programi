
namespace mail_gonderme
{
    partial class frmMailGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailGonder));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.cmbGonderici = new System.Windows.Forms.ComboBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.tbxDosyaYolu = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHtmlNo = new System.Windows.Forms.RadioButton();
            this.rbtnHtmlOk = new System.Windows.Forms.RadioButton();
            this.hataMesaji = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.linkWebsite = new System.Windows.Forms.LinkLabel();
            this.openYolSec = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hataMesaji)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 300);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDosyaSec);
            this.tabPage1.Controls.Add(this.cmbGonderici);
            this.tabPage1.Controls.Add(this.txtAlici);
            this.tabPage1.Controls.Add(this.btnGonder);
            this.tabPage1.Controls.Add(this.tbxDosyaYolu);
            this.tabPage1.Controls.Add(this.txtKonu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rtxtMesaj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "✉ Gönder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(243, 105);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(59, 23);
            this.btnDosyaSec.TabIndex = 6;
            this.btnDosyaSec.Text = "Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // cmbGonderici
            // 
            this.cmbGonderici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGonderici.FormattingEnabled = true;
            this.cmbGonderici.Items.AddRange(new object[] {
            "erhanrgn",
            "erhanurgun.com.tr"});
            this.cmbGonderici.Location = new System.Drawing.Point(79, 20);
            this.cmbGonderici.Name = "cmbGonderici";
            this.cmbGonderici.Size = new System.Drawing.Size(223, 24);
            this.cmbGonderici.TabIndex = 1;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(79, 50);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(223, 22);
            this.txtAlici.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(79, 202);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(224, 53);
            this.btnGonder.TabIndex = 5;
            this.btnGonder.Text = "✈️ GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // tbxDosyaYolu
            // 
            this.tbxDosyaYolu.Location = new System.Drawing.Point(79, 106);
            this.tbxDosyaYolu.Name = "tbxDosyaYolu";
            this.tbxDosyaYolu.Size = new System.Drawing.Size(158, 22);
            this.tbxDosyaYolu.TabIndex = 3;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(79, 78);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(223, 22);
            this.txtKonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mesaj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dosya:";
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(79, 135);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.Size = new System.Drawing.Size(223, 61);
            this.rtxtMesaj.TabIndex = 4;
            this.rtxtMesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alıcı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gönderici:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "⚙️ Ayarlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHtmlNo);
            this.groupBox1.Controls.Add(this.rbtnHtmlOk);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " HTML Etiketi";
            // 
            // rbtnHtmlNo
            // 
            this.rbtnHtmlNo.AutoSize = true;
            this.rbtnHtmlNo.Location = new System.Drawing.Point(14, 45);
            this.rbtnHtmlNo.Name = "rbtnHtmlNo";
            this.rbtnHtmlNo.Size = new System.Drawing.Size(81, 20);
            this.rbtnHtmlNo.TabIndex = 0;
            this.rbtnHtmlNo.TabStop = true;
            this.rbtnHtmlNo.Text = "Kullanma";
            this.rbtnHtmlNo.UseVisualStyleBackColor = true;
            // 
            // rbtnHtmlOk
            // 
            this.rbtnHtmlOk.AutoSize = true;
            this.rbtnHtmlOk.Location = new System.Drawing.Point(14, 20);
            this.rbtnHtmlOk.Name = "rbtnHtmlOk";
            this.rbtnHtmlOk.Size = new System.Drawing.Size(62, 20);
            this.rbtnHtmlOk.TabIndex = 0;
            this.rbtnHtmlOk.TabStop = true;
            this.rbtnHtmlOk.Text = "Kullan";
            this.rbtnHtmlOk.UseVisualStyleBackColor = true;
            // 
            // hataMesaji
            // 
            this.hataMesaji.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Copyright © Tüm hakları saklıdır. \r\nTasarlayan 💖 ";
            // 
            // linkWebsite
            // 
            this.linkWebsite.AutoSize = true;
            this.linkWebsite.Location = new System.Drawing.Point(173, 326);
            this.linkWebsite.Name = "linkWebsite";
            this.linkWebsite.Size = new System.Drawing.Size(114, 16);
            this.linkWebsite.TabIndex = 9;
            this.linkWebsite.TabStop = true;
            this.linkWebsite.Text = "erhanurgun.com.tr";
            this.linkWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
            // 
            // openYolSec
            // 
            this.openYolSec.FileName = "openFileDialog1";
            // 
            // frmMailGonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 347);
            this.Controls.Add(this.linkWebsite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMailGonder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderme Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hataMesaji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbGonderici;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHtmlNo;
        private System.Windows.Forms.RadioButton rbtnHtmlOk;
        private System.Windows.Forms.ErrorProvider hataMesaji;
        private System.Windows.Forms.LinkLabel linkWebsite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.TextBox tbxDosyaYolu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openYolSec;
    }
}

