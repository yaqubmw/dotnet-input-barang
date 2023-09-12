namespace FormInputBarang
{
    partial class FormInputBarang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.NegaraTextBox = new System.Windows.Forms.TextBox();
            this.PelabuhanTextBox = new System.Windows.Forms.TextBox();
            this.KodeBarangTextBox = new System.Windows.Forms.TextBox();
            this.PreviewBarangTextBox = new System.Windows.Forms.TextBox();
            this.HargaTextBox = new System.Windows.Forms.TextBox();
            this.TarifBeaMasukTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            
            
            this.NegaraTextBox.Location = new System.Drawing.Point(176, 23);
            this.NegaraTextBox.Name = "NegaraTextBox";
            this.NegaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.NegaraTextBox.TabIndex = 0;
            this.NegaraTextBox.TextChanged += new System.EventHandler(this.NegaraTextBox_TextChanged);
            
            
            
            this.PelabuhanTextBox.Location = new System.Drawing.Point(176, 61);
            this.PelabuhanTextBox.Name = "PelabuhanTextBox";
            this.PelabuhanTextBox.Size = new System.Drawing.Size(100, 20);
            this.PelabuhanTextBox.TabIndex = 1;
            this.PelabuhanTextBox.TextChanged += new System.EventHandler(this.PelabuhanTextBox_TextChanged);
            
            
            
            this.KodeBarangTextBox.Location = new System.Drawing.Point(176, 99);
            this.KodeBarangTextBox.Name = "KodeBarangTextBox";
            this.KodeBarangTextBox.Size = new System.Drawing.Size(100, 20);
            this.KodeBarangTextBox.TabIndex = 2;
            this.KodeBarangTextBox.TextChanged += new System.EventHandler(this.KodeBarangTextBox_TextChanged);
            
            
            
            this.PreviewBarangTextBox.Location = new System.Drawing.Point(176, 137);
            this.PreviewBarangTextBox.Name = "PreviewBarangTextBox";
            this.PreviewBarangTextBox.Size = new System.Drawing.Size(100, 20);
            this.PreviewBarangTextBox.TabIndex = 3;
            
            
            
            this.HargaTextBox.Location = new System.Drawing.Point(176, 175);
            this.HargaTextBox.Name = "HargaTextBox";
            this.HargaTextBox.Size = new System.Drawing.Size(100, 20);
            this.HargaTextBox.TabIndex = 4;
            
            
            
            this.TarifBeaMasukTextBox.Location = new System.Drawing.Point(176, 213);
            this.TarifBeaMasukTextBox.Name = "TarifBeaMasukTextBox";
            this.TarifBeaMasukTextBox.Size = new System.Drawing.Size(100, 20);
            this.TarifBeaMasukTextBox.TabIndex = 5;
            
            
            
            this.TotalTextBox.Location = new System.Drawing.Point(176, 251);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 6;
            
            
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Negara:";
            
            
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pelabuhan:";
            
            
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kode Barang:";
            
            
            
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "";
            
            
            
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Harga:";
            
            
            
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tarif Bea Masuk:";
            
            
            
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 297);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.TarifBeaMasukTextBox);
            this.Controls.Add(this.HargaTextBox);
            this.Controls.Add(this.PreviewBarangTextBox);
            this.Controls.Add(this.KodeBarangTextBox);
            this.Controls.Add(this.PelabuhanTextBox);
            this.Controls.Add(this.NegaraTextBox);
            this.Name = "FormInputBarang";
            this.Text = "Input Barang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox NegaraTextBox;
        private System.Windows.Forms.TextBox PelabuhanTextBox;
        private System.Windows.Forms.TextBox KodeBarangTextBox;
        private System.Windows.Forms.TextBox PreviewBarangTextBox;
        private System.Windows.Forms.TextBox HargaTextBox;
        private System.Windows.Forms.TextBox TarifBeaMasukTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
