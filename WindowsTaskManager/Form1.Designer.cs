namespace WindowsTaskManager
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
            this.zatvoriProces = new System.Windows.Forms.Button();
            this.ListaProcesa = new System.Windows.Forms.ListBox();
            this.BtnZatvoriProces = new System.Windows.Forms.Button();
            this.BtnPrikaziListuProcesa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOtvoriProces = new System.Windows.Forms.Button();
            this.ListKarakteristikeProcesa = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zatvoriProces
            // 
            this.zatvoriProces.Location = new System.Drawing.Point(13, 43);
            this.zatvoriProces.Name = "zatvoriProces";
            this.zatvoriProces.Size = new System.Drawing.Size(115, 23);
            this.zatvoriProces.TabIndex = 1;
            this.zatvoriProces.Text = "Zatvori proces";
            this.zatvoriProces.UseVisualStyleBackColor = true;
            this.zatvoriProces.Click += new System.EventHandler(this.zatvoriProces_Click);
            // 
            // ListaProcesa
            // 
            this.ListaProcesa.DisplayMember = "processName";
            this.ListaProcesa.FormattingEnabled = true;
            this.ListaProcesa.Location = new System.Drawing.Point(13, 102);
            this.ListaProcesa.Name = "ListaProcesa";
            this.ListaProcesa.Size = new System.Drawing.Size(254, 316);
            this.ListaProcesa.TabIndex = 5;
            this.ListaProcesa.SelectedIndexChanged += new System.EventHandler(this.ListaProcesa_SelectedIndexChanged);
            // 
            // BtnZatvoriProces
            // 
            this.BtnZatvoriProces.Location = new System.Drawing.Point(273, 72);
            this.BtnZatvoriProces.Name = "BtnZatvoriProces";
            this.BtnZatvoriProces.Size = new System.Drawing.Size(87, 23);
            this.BtnZatvoriProces.TabIndex = 7;
            this.BtnZatvoriProces.Text = "Zatvori Proces";
            this.BtnZatvoriProces.UseVisualStyleBackColor = true;
            this.BtnZatvoriProces.Click += new System.EventHandler(this.BtnZatvoriProces_Click);
            // 
            // BtnPrikaziListuProcesa
            // 
            this.BtnPrikaziListuProcesa.Location = new System.Drawing.Point(13, 73);
            this.BtnPrikaziListuProcesa.Name = "BtnPrikaziListuProcesa";
            this.BtnPrikaziListuProcesa.Size = new System.Drawing.Size(115, 23);
            this.BtnPrikaziListuProcesa.TabIndex = 8;
            this.BtnPrikaziListuProcesa.Text = "Prikaži listu procesa";
            this.BtnPrikaziListuProcesa.UseVisualStyleBackColor = true;
            this.BtnPrikaziListuProcesa.Click += new System.EventHandler(this.BtnPrikaziListuProcesa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOtvoriProces
            // 
            this.BtnOtvoriProces.Location = new System.Drawing.Point(13, 13);
            this.BtnOtvoriProces.Name = "BtnOtvoriProces";
            this.BtnOtvoriProces.Size = new System.Drawing.Size(115, 23);
            this.BtnOtvoriProces.TabIndex = 12;
            this.BtnOtvoriProces.Text = "Otvori proces";
            this.BtnOtvoriProces.UseVisualStyleBackColor = true;
            this.BtnOtvoriProces.Click += new System.EventHandler(this.BtnOtvoriProces_Click);
            // 
            // ListKarakteristikeProcesa
            // 
            this.ListKarakteristikeProcesa.FormattingEnabled = true;
            this.ListKarakteristikeProcesa.Location = new System.Drawing.Point(274, 102);
            this.ListKarakteristikeProcesa.Name = "ListKarakteristikeProcesa";
            this.ListKarakteristikeProcesa.Size = new System.Drawing.Size(253, 316);
            this.ListKarakteristikeProcesa.TabIndex = 13;
            this.ListKarakteristikeProcesa.SelectedIndexChanged += new System.EventHandler(this.ListKarakteristikeProcesa_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListKarakteristikeProcesa);
            this.Controls.Add(this.BtnOtvoriProces);
            this.Controls.Add(this.BtnPrikaziListuProcesa);
            this.Controls.Add(this.BtnZatvoriProces);
            this.Controls.Add(this.ListaProcesa);
            this.Controls.Add(this.zatvoriProces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zatvoriProces;
        private System.Windows.Forms.ListBox ListaProcesa;
        private System.Windows.Forms.Button BtnZatvoriProces;
        private System.Windows.Forms.Button BtnPrikaziListuProcesa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOtvoriProces;
        private System.Windows.Forms.ListBox ListKarakteristikeProcesa;
        private System.Windows.Forms.TextBox textBox1;
    }
}

