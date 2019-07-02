namespace PIM1
{
    partial class frmCadVeiculos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.mskAno = new System.Windows.Forms.MaskedTextBox();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMotorizacao = new System.Windows.Forms.ComboBox();
            this.txtKmAtual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(249, 24);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(53, 24);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // mskAno
            // 
            this.mskAno.Location = new System.Drawing.Point(53, 60);
            this.mskAno.Mask = "0000";
            this.mskAno.Name = "mskAno";
            this.mskAno.Size = new System.Drawing.Size(100, 20);
            this.mskAno.TabIndex = 8;
            this.mskAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskAno.ValidatingType = typeof(System.DateTime);
            // 
            // mskPlaca
            // 
            this.mskPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskPlaca.Location = new System.Drawing.Point(249, 60);
            this.mskPlaca.Mask = "aaa-aaa";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(100, 20);
            this.mskPlaca.TabIndex = 9;
            this.mskPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(249, 99);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(100, 20);
            this.txtRenavam.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Renavam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(53, 96);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Motor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "KM Atual:";
            // 
            // cmbMotorizacao
            // 
            this.cmbMotorizacao.FormattingEnabled = true;
            this.cmbMotorizacao.Items.AddRange(new object[] {
            "1.0",
            "1.6",
            "1.8",
            "2.0",
            "2.2",
            "Outro"});
            this.cmbMotorizacao.Location = new System.Drawing.Point(100, 227);
            this.cmbMotorizacao.Name = "cmbMotorizacao";
            this.cmbMotorizacao.Size = new System.Drawing.Size(61, 21);
            this.cmbMotorizacao.TabIndex = 16;
            // 
            // txtKmAtual
            // 
            this.txtKmAtual.Location = new System.Drawing.Point(66, 49);
            this.txtKmAtual.Name = "txtKmAtual";
            this.txtKmAtual.Size = new System.Drawing.Size(100, 20);
            this.txtKmAtual.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "UF:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(274, 227);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(36, 20);
            this.txtEstado.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtKmAtual);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 81);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veiculo é zero KM?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(42, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sim";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Manutenção em dia:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(316, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(45, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(304, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmCadVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 324);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMotorizacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.mskPlaca);
            this.Controls.Add(this.mskAno);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadVeiculos";
            this.Text = "Cadastro de Veiculos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.MaskedTextBox mskAno;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMotorizacao;
        private System.Windows.Forms.TextBox txtKmAtual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}