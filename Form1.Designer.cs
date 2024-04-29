
namespace Veri_bağlama_uygulama_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.btnVeriBağla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Enabled = false;
            this.txtNumara.Location = new System.Drawing.Point(226, 43);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(98, 20);
            this.txtNumara.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(226, 92);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(98, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alan";
            // 
            // txtAlan
            // 
            this.txtAlan.Enabled = false;
            this.txtAlan.Location = new System.Drawing.Point(226, 149);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(98, 20);
            this.txtAlan.TabIndex = 1;
            this.txtAlan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnVeriBağla
            // 
            this.btnVeriBağla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriBağla.Location = new System.Drawing.Point(370, 80);
            this.btnVeriBağla.Name = "btnVeriBağla";
            this.btnVeriBağla.Size = new System.Drawing.Size(76, 89);
            this.btnVeriBağla.TabIndex = 2;
            this.btnVeriBağla.Text = "Veri Bağla";
            this.btnVeriBağla.UseVisualStyleBackColor = true;
            this.btnVeriBağla.Click += new System.EventHandler(this.btnVeriBağla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeriBağla);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Button btnVeriBağla;
    }
}

