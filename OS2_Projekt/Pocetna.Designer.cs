
namespace OS2_Projekt
{
    partial class Pocetna
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDekriptirajSim = new System.Windows.Forms.Button();
            this.btnKriptirajSim = new System.Windows.Forms.Button();
            this.btnGenerirajSimKlj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDekriptirajAsim = new System.Windows.Forms.Button();
            this.btnKriptirajAsim = new System.Windows.Forms.Button();
            this.btnGenerirajParKlj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.btnIzradi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrginalniTekst = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNazivDatoteke = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(459, 23);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(124, 84);
            this.btnUcitaj.TabIndex = 0;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDekriptirajSim);
            this.groupBox1.Controls.Add(this.btnKriptirajSim);
            this.groupBox1.Controls.Add(this.btnGenerirajSimKlj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simetrični kriptosustav";
            // 
            // btnDekriptirajSim
            // 
            this.btnDekriptirajSim.Location = new System.Drawing.Point(138, 131);
            this.btnDekriptirajSim.Name = "btnDekriptirajSim";
            this.btnDekriptirajSim.Size = new System.Drawing.Size(141, 38);
            this.btnDekriptirajSim.TabIndex = 5;
            this.btnDekriptirajSim.Text = "Dekriptiraj";
            this.btnDekriptirajSim.UseVisualStyleBackColor = true;
            this.btnDekriptirajSim.Click += new System.EventHandler(this.btnDekriptirajSim_Click);
            // 
            // btnKriptirajSim
            // 
            this.btnKriptirajSim.Location = new System.Drawing.Point(138, 79);
            this.btnKriptirajSim.Name = "btnKriptirajSim";
            this.btnKriptirajSim.Size = new System.Drawing.Size(141, 38);
            this.btnKriptirajSim.TabIndex = 4;
            this.btnKriptirajSim.Text = "Kriptiraj";
            this.btnKriptirajSim.UseVisualStyleBackColor = true;
            this.btnKriptirajSim.Click += new System.EventHandler(this.btnKriptirajSim_Click);
            // 
            // btnGenerirajSimKlj
            // 
            this.btnGenerirajSimKlj.Location = new System.Drawing.Point(10, 25);
            this.btnGenerirajSimKlj.Name = "btnGenerirajSimKlj";
            this.btnGenerirajSimKlj.Size = new System.Drawing.Size(165, 38);
            this.btnGenerirajSimKlj.TabIndex = 2;
            this.btnGenerirajSimKlj.Text = "Generiraj tajni ključ";
            this.btnGenerirajSimKlj.UseVisualStyleBackColor = true;
            this.btnGenerirajSimKlj.Click += new System.EventHandler(this.btnGenerirajSimKlj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDekriptirajAsim);
            this.groupBox2.Controls.Add(this.btnKriptirajAsim);
            this.groupBox2.Controls.Add(this.btnGenerirajParKlj);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(461, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asimetrični kriptosustav";
            // 
            // btnDekriptirajAsim
            // 
            this.btnDekriptirajAsim.Location = new System.Drawing.Point(143, 131);
            this.btnDekriptirajAsim.Name = "btnDekriptirajAsim";
            this.btnDekriptirajAsim.Size = new System.Drawing.Size(141, 38);
            this.btnDekriptirajAsim.TabIndex = 5;
            this.btnDekriptirajAsim.Text = "Dekriptiraj";
            this.btnDekriptirajAsim.UseVisualStyleBackColor = true;
            this.btnDekriptirajAsim.Click += new System.EventHandler(this.btnDekriptirajAsim_Click);
            // 
            // btnKriptirajAsim
            // 
            this.btnKriptirajAsim.Location = new System.Drawing.Point(143, 79);
            this.btnKriptirajAsim.Name = "btnKriptirajAsim";
            this.btnKriptirajAsim.Size = new System.Drawing.Size(141, 38);
            this.btnKriptirajAsim.TabIndex = 4;
            this.btnKriptirajAsim.Text = "Kriptiraj";
            this.btnKriptirajAsim.UseVisualStyleBackColor = true;
            this.btnKriptirajAsim.Click += new System.EventHandler(this.btnKriptirajAsim_Click);
            // 
            // btnGenerirajParKlj
            // 
            this.btnGenerirajParKlj.Location = new System.Drawing.Point(10, 25);
            this.btnGenerirajParKlj.Name = "btnGenerirajParKlj";
            this.btnGenerirajParKlj.Size = new System.Drawing.Size(175, 38);
            this.btnGenerirajParKlj.TabIndex = 2;
            this.btnGenerirajParKlj.Text = "Generiraj par ključeva";
            this.btnGenerirajParKlj.UseVisualStyleBackColor = true;
            this.btnGenerirajParKlj.Click += new System.EventHandler(this.btnGenerirajParKlj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kriptiraj tekst:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dekriptiraj tekst:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSHA256);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 192);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sažetak ";
            // 
            // btnSHA256
            // 
            this.btnSHA256.Location = new System.Drawing.Point(150, 41);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Size = new System.Drawing.Size(141, 38);
            this.btnSHA256.TabIndex = 2;
            this.btnSHA256.Text = "SHA256";
            this.btnSHA256.UseVisualStyleBackColor = true;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Izračunaj sažetak:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnProvjeri);
            this.groupBox4.Controls.Add(this.btnIzradi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(461, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 192);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digitalni potpis";
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(91, 95);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(141, 38);
            this.btnProvjeri.TabIndex = 4;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // btnIzradi
            // 
            this.btnIzradi.Location = new System.Drawing.Point(91, 41);
            this.btnIzradi.Name = "btnIzradi";
            this.btnIzradi.Size = new System.Drawing.Size(141, 38);
            this.btnIzradi.TabIndex = 2;
            this.btnIzradi.Text = "Izradi";
            this.btnIzradi.UseVisualStyleBackColor = true;
            this.btnIzradi.Click += new System.EventHandler(this.btnIzradi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Potpiši:";
            // 
            // txtOrginalniTekst
            // 
            this.txtOrginalniTekst.Location = new System.Drawing.Point(6, 23);
            this.txtOrginalniTekst.Multiline = true;
            this.txtOrginalniTekst.Name = "txtOrginalniTekst";
            this.txtOrginalniTekst.Size = new System.Drawing.Size(447, 81);
            this.txtOrginalniTekst.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNazivDatoteke);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtOrginalniTekst);
            this.groupBox5.Controls.Add(this.btnUcitaj);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(880, 126);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datoteka";
            // 
            // txtNazivDatoteke
            // 
            this.txtNazivDatoteke.Location = new System.Drawing.Point(589, 47);
            this.txtNazivDatoteke.Multiline = true;
            this.txtNazivDatoteke.Name = "txtNazivDatoteke";
            this.txtNazivDatoteke.Size = new System.Drawing.Size(277, 57);
            this.txtNazivDatoteke.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Naziv datoteke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kriptiraj tekst:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dekriptiraj tekst:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Provjeri:";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 585);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pocetna";
            this.Text = "Pocetna ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDekriptirajSim;
        private System.Windows.Forms.Button btnKriptirajSim;
        private System.Windows.Forms.Button btnGenerirajSimKlj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDekriptirajAsim;
        private System.Windows.Forms.Button btnKriptirajAsim;
        private System.Windows.Forms.Button btnGenerirajParKlj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.Button btnIzradi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrginalniTekst;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNazivDatoteke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

