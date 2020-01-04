namespace Veri_Arama_Motoru
{
    partial class Arama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arama));
            this.label3 = new System.Windows.Forms.Label();
            this.yaklasikDeger = new System.Windows.Forms.LinkLabel();
            this.AraBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bulunanlarLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(11, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ARAMA MOTORU";
            // 
            // yaklasikDeger
            // 
            this.yaklasikDeger.AutoSize = true;
            this.yaklasikDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yaklasikDeger.ForeColor = System.Drawing.Color.ForestGreen;
            this.yaklasikDeger.LinkColor = System.Drawing.Color.Green;
            this.yaklasikDeger.Location = new System.Drawing.Point(732, 420);
            this.yaklasikDeger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yaklasikDeger.Name = "yaklasikDeger";
            this.yaklasikDeger.Size = new System.Drawing.Size(45, 20);
            this.yaklasikDeger.TabIndex = 4;
            this.yaklasikDeger.TabStop = true;
            this.yaklasikDeger.Text = ".........";
            this.yaklasikDeger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.yaklasikDeger_LinkClicked);
            // 
            // AraBtn
            // 
            this.AraBtn.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AraBtn.Image = ((System.Drawing.Image)(resources.GetObject("AraBtn.Image")));
            this.AraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AraBtn.Location = new System.Drawing.Point(64, 103);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(122, 61);
            this.AraBtn.TabIndex = 6;
            this.AraBtn.Text = "ARA";
            this.AraBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AraBtn.UseVisualStyleBackColor = true;
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "ARAMAK İSTENİLEN İFADE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(29, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 7;
            // 
            // bulunanlarLB
            // 
            this.bulunanlarLB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulunanlarLB.FormattingEnabled = true;
            this.bulunanlarLB.HorizontalScrollbar = true;
            this.bulunanlarLB.ItemHeight = 16;
            this.bulunanlarLB.Location = new System.Drawing.Point(276, 70);
            this.bulunanlarLB.Name = "bulunanlarLB";
            this.bulunanlarLB.Size = new System.Drawing.Size(568, 340);
            this.bulunanlarLB.TabIndex = 10;
            this.bulunanlarLB.SelectedIndexChanged += new System.EventHandler(this.bulunanlarLB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(443, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "BULUNAN YERLER / CUMLELER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(477, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "BUNU MU DEMEK ISTEDINIZ ? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(769, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "ADET :";
            // 
            // Arama
            // 
            this.AcceptButton = this.AraBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(856, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yaklasikDeger);
            this.Controls.Add(this.bulunanlarLB);
            this.Controls.Add(this.AraBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEDAT KIRÇA - VERİ YAPILARI DERSİ PROJE ÖDEVİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel yaklasikDeger;
        private System.Windows.Forms.Button AraBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox bulunanlarLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}