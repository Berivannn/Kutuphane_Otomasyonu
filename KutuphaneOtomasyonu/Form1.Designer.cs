namespace KutuphaneOtomasyonu
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
            System.Windows.Forms.Label lblBarkodno;
            System.Windows.Forms.Label lblAd;
            System.Windows.Forms.Label ldbYazar;
            System.Windows.Forms.Label lblFiyat;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBarkodno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            lblBarkodno = new System.Windows.Forms.Label();
            lblAd = new System.Windows.Forms.Label();
            ldbYazar = new System.Windows.Forms.Label();
            lblFiyat = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarkodno
            // 
            lblBarkodno.AutoSize = true;
            lblBarkodno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            lblBarkodno.Location = new System.Drawing.Point(15, 20);
            lblBarkodno.Name = "lblBarkodno";
            lblBarkodno.Size = new System.Drawing.Size(94, 24);
            lblBarkodno.TabIndex = 0;
            lblBarkodno.Text = "BarkodNo";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            lblAd.Location = new System.Drawing.Point(15, 56);
            lblAd.Name = "lblAd";
            lblAd.Size = new System.Drawing.Size(34, 24);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // ldbYazar
            // 
            ldbYazar.AutoSize = true;
            ldbYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ldbYazar.Location = new System.Drawing.Point(15, 96);
            ldbYazar.Name = "ldbYazar";
            ldbYazar.Size = new System.Drawing.Size(61, 24);
            ldbYazar.TabIndex = 4;
            ldbYazar.Text = "Yazarı";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            lblFiyat.Location = new System.Drawing.Point(15, 132);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new System.Drawing.Size(53, 24);
            lblFiyat.TabIndex = 6;
            lblFiyat.Text = "Fiyatı";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Kaydet";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(679, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "Göster";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtFiyat);
            this.panel1.Controls.Add(lblFiyat);
            this.panel1.Controls.Add(this.txtYazar);
            this.panel1.Controls.Add(ldbYazar);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(lblAd);
            this.panel1.Controls.Add(this.txtBarkodno);
            this.panel1.Controls.Add(lblBarkodno);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 312);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(66, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 35);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(112, 137);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(91, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(112, 96);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(91, 20);
            this.txtYazar.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 59);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(91, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtBarkodno
            // 
            this.txtBarkodno.Location = new System.Drawing.Point(112, 23);
            this.txtBarkodno.Name = "txtBarkodno";
            this.txtBarkodno.Size = new System.Drawing.Size(91, 20);
            this.txtBarkodno.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 312);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(232, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 140);
            this.panel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 377);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Kutuphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBarkodno;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
    }
}

