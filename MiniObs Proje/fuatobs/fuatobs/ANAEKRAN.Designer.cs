namespace fuatobs
{
    partial class ANA_EKRAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANA_EKRAN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Kullanıcıadı = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.BTN_GİRİŞ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE:";
            // 
            // txt_Kullanıcıadı
            // 
            this.txt_Kullanıcıadı.Location = new System.Drawing.Point(190, 79);
            this.txt_Kullanıcıadı.Name = "txt_Kullanıcıadı";
            this.txt_Kullanıcıadı.Size = new System.Drawing.Size(232, 22);
            this.txt_Kullanıcıadı.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(190, 147);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(232, 22);
            this.txt_Sifre.TabIndex = 3;
            // 
            // BTN_GİRİŞ
            // 
            this.BTN_GİRİŞ.Location = new System.Drawing.Point(190, 200);
            this.BTN_GİRİŞ.Name = "BTN_GİRİŞ";
            this.BTN_GİRİŞ.Size = new System.Drawing.Size(232, 27);
            this.BTN_GİRİŞ.TabIndex = 4;
            this.BTN_GİRİŞ.Text = "GİRİŞ";
            this.BTN_GİRİŞ.UseVisualStyleBackColor = true;
            this.BTN_GİRİŞ.Click += new System.EventHandler(this.BTN_GİRİŞ_Click);
            // 
            // ANA_EKRAN
            // 
            this.AcceptButton = this.BTN_GİRİŞ;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::fuatobs.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 532);
            this.Controls.Add(this.BTN_GİRİŞ);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kullanıcıadı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ANA_EKRAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISUBÜ OBS ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Kullanıcıadı;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button BTN_GİRİŞ;
    }
}