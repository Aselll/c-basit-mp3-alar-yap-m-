namespace mp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnoynat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnac = new System.Windows.Forms.Button();
            this.btndurdur = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnoynat
            // 
            this.btnoynat.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnoynat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoynat.Location = new System.Drawing.Point(12, 109);
            this.btnoynat.Name = "btnoynat";
            this.btnoynat.Size = new System.Drawing.Size(106, 36);
            this.btnoynat.TabIndex = 0;
            this.btnoynat.Text = "OYNAT";
            this.btnoynat.UseVisualStyleBackColor = false;
            this.btnoynat.Click += new System.EventHandler(this.Btnoynat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnac
            // 
            this.btnac.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnac.Location = new System.Drawing.Point(12, 69);
            this.btnac.Name = "btnac";
            this.btnac.Size = new System.Drawing.Size(106, 34);
            this.btnac.TabIndex = 2;
            this.btnac.Text = "AÇ";
            this.btnac.UseVisualStyleBackColor = false;
            this.btnac.Click += new System.EventHandler(this.Btnac_Click);
            // 
            // btndurdur
            // 
            this.btndurdur.BackColor = System.Drawing.Color.LemonChiffon;
            this.btndurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndurdur.Location = new System.Drawing.Point(13, 151);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(105, 35);
            this.btndurdur.TabIndex = 3;
            this.btndurdur.Text = "DURDUR";
            this.btndurdur.UseVisualStyleBackColor = false;
            this.btndurdur.Click += new System.EventHandler(this.Btndurdur_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(165, 61);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(359, 172);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 278);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btnac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnoynat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoynat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnac;
        private System.Windows.Forms.Button btndurdur;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

