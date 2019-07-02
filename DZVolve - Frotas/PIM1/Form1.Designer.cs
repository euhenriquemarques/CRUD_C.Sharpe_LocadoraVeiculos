namespace PIM1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbrg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbOe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbuf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbmunicipio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbendereco = new System.Windows.Forms.TextBox();
            this.txbUfexp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbbairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbnumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbcomplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbcnh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbVcnh = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbtelefone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txbcelular = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bdview = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(85, 69);
            this.txbnome.Margin = new System.Windows.Forms.Padding(2);
            this.txbnome.Name = "txbnome";
            this.txbnome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbnome.Size = new System.Drawing.Size(150, 20);
            this.txbnome.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(23, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(105, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pessoa Física";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(145, 27);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(114, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Pessoa Juridica";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF/CNPJ:";
            // 
            // txbcpf
            // 
            this.txbcpf.Location = new System.Drawing.Point(313, 69);
            this.txbcpf.Margin = new System.Windows.Forms.Padding(2);
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(158, 20);
            this.txbcpf.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG:";
            // 
            // txbrg
            // 
            this.txbrg.Location = new System.Drawing.Point(523, 69);
            this.txbrg.Margin = new System.Windows.Forms.Padding(2);
            this.txbrg.Name = "txbrg";
            this.txbrg.Size = new System.Drawing.Size(162, 20);
            this.txbrg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Org. Exp:";
            // 
            // txbOe
            // 
            this.txbOe.Location = new System.Drawing.Point(523, 98);
            this.txbOe.Margin = new System.Windows.Forms.Padding(2);
            this.txbOe.Name = "txbOe";
            this.txbOe.Size = new System.Drawing.Size(61, 20);
            this.txbOe.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uf. Exp:";
            // 
            // txbuf
            // 
            this.txbuf.Location = new System.Drawing.Point(312, 212);
            this.txbuf.Margin = new System.Windows.Forms.Padding(2);
            this.txbuf.Name = "txbuf";
            this.txbuf.Size = new System.Drawing.Size(37, 20);
            this.txbuf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Nasc.:";
            // 
            // txbData
            // 
            this.txbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbData.Location = new System.Drawing.Point(85, 140);
            this.txbData.Margin = new System.Windows.Forms.Padding(2);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(62, 19);
            this.txbData.TabIndex = 14;
            this.txbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-Mail:";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(523, 248);
            this.txbemail.Margin = new System.Windows.Forms.Padding(2);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(177, 20);
            this.txbemail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Municipio:";
            // 
            // txbmunicipio
            // 
            this.txbmunicipio.Location = new System.Drawing.Point(85, 212);
            this.txbmunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txbmunicipio.Name = "txbmunicipio";
            this.txbmunicipio.Size = new System.Drawing.Size(150, 20);
            this.txbmunicipio.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Uf:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cep-Rua/Av:";
            // 
            // txbendereco
            // 
            this.txbendereco.Location = new System.Drawing.Point(85, 175);
            this.txbendereco.Margin = new System.Windows.Forms.Padding(2);
            this.txbendereco.Name = "txbendereco";
            this.txbendereco.Size = new System.Drawing.Size(150, 20);
            this.txbendereco.TabIndex = 21;
            // 
            // txbUfexp
            // 
            this.txbUfexp.Location = new System.Drawing.Point(637, 98);
            this.txbUfexp.Margin = new System.Windows.Forms.Padding(2);
            this.txbUfexp.Name = "txbUfexp";
            this.txbUfexp.Size = new System.Drawing.Size(48, 20);
            this.txbUfexp.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bairro:";
            // 
            // txbbairro
            // 
            this.txbbairro.Location = new System.Drawing.Point(390, 179);
            this.txbbairro.Margin = new System.Windows.Forms.Padding(2);
            this.txbbairro.Name = "txbbairro";
            this.txbbairro.Size = new System.Drawing.Size(86, 20);
            this.txbbairro.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nº:";
            // 
            // txbnumero
            // 
            this.txbnumero.Location = new System.Drawing.Point(313, 179);
            this.txbnumero.Margin = new System.Windows.Forms.Padding(2);
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.Size = new System.Drawing.Size(36, 20);
            this.txbnumero.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(480, 182);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Compl.:";
            // 
            // txbcomplemento
            // 
            this.txbcomplemento.Location = new System.Drawing.Point(523, 175);
            this.txbcomplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txbcomplemento.Name = "txbcomplemento";
            this.txbcomplemento.Size = new System.Drawing.Size(162, 20);
            this.txbcomplemento.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Nº Cnh:";
            // 
            // txbcnh
            // 
            this.txbcnh.Location = new System.Drawing.Point(85, 105);
            this.txbcnh.Margin = new System.Windows.Forms.Padding(2);
            this.txbcnh.Name = "txbcnh";
            this.txbcnh.Size = new System.Drawing.Size(150, 20);
            this.txbcnh.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(258, 107);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Vnct Cnh:";
            // 
            // txbVcnh
            // 
            this.txbVcnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVcnh.Location = new System.Drawing.Point(313, 105);
            this.txbVcnh.Margin = new System.Windows.Forms.Padding(2);
            this.txbVcnh.Name = "txbVcnh";
            this.txbVcnh.Size = new System.Drawing.Size(63, 19);
            this.txbVcnh.TabIndex = 32;
            this.txbVcnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 251);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Telefone:";
            // 
            // txbtelefone
            // 
            this.txbtelefone.Location = new System.Drawing.Point(85, 251);
            this.txbtelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txbtelefone.Name = "txbtelefone";
            this.txbtelefone.Size = new System.Drawing.Size(150, 20);
            this.txbtelefone.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 248);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Celular:";
            // 
            // txbcelular
            // 
            this.txbcelular.Location = new System.Drawing.Point(312, 248);
            this.txbcelular.Margin = new System.Windows.Forms.Padding(2);
            this.txbcelular.Name = "txbcelular";
            this.txbcelular.Size = new System.Drawing.Size(159, 20);
            this.txbcelular.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(574, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 34);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bdview
            // 
            this.bdview.AllowUserToAddRows = false;
            this.bdview.AllowUserToDeleteRows = false;
            this.bdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdview.Location = new System.Drawing.Point(5, 297);
            this.bdview.Name = "bdview";
            this.bdview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdview.Size = new System.Drawing.Size(715, 144);
            this.bdview.TabIndex = 40;
            this.bdview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bdview_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(409, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(492, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 34);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(325, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(35, 34);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(361, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 15);
            this.label18.TabIndex = 43;
            this.label18.Text = "Salvar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(446, 31);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 15);
            this.label19.TabIndex = 44;
            this.label19.Text = "Editar";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(528, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 15);
            this.label20.TabIndex = 45;
            this.label20.Text = "Excluir";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(611, 31);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "Cancelar Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bdview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbcelular);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txbtelefone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txbVcnh);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txbcnh);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txbcomplemento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbnumero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbbairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbUfexp);
            this.Controls.Add(this.txbendereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbmunicipio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbuf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbOe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbrg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txbnome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.bdview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbOe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbuf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbmunicipio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbendereco;
        private System.Windows.Forms.TextBox txbUfexp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbbairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbnumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbcomplemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbcnh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbVcnh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbtelefone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbcelular;
        private System.Windows.Forms.DataGridView bdview;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        protected System.Windows.Forms.Button button1;
    }
}

