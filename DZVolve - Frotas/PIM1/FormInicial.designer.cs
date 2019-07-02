namespace PIM1
{
    partial class frmInicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.brnFinancas = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnManutencoes = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnViagens = new System.Windows.Forms.Button();
            this.btnGaragem = new System.Windows.Forms.Button();
            this.btnSaidaEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha abaixo a opção no qual deseja visitar:";
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Location = new System.Drawing.Point(85, 63);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(166, 23);
            this.btnVeiculos.TabIndex = 1;
            this.btnVeiculos.Text = "Cadastrar Veiculos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            this.btnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(85, 102);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(166, 23);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Cadastrar Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // brnFinancas
            // 
            this.brnFinancas.Location = new System.Drawing.Point(85, 144);
            this.brnFinancas.Name = "brnFinancas";
            this.brnFinancas.Size = new System.Drawing.Size(166, 23);
            this.brnFinancas.TabIndex = 3;
            this.brnFinancas.Text = "Finanças";
            this.brnFinancas.UseVisualStyleBackColor = true;
            this.brnFinancas.Click += new System.EventHandler(this.BrnFinancas_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(85, 184);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(166, 23);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque Entrada";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnManutencoes
            // 
            this.btnManutencoes.Location = new System.Drawing.Point(361, 63);
            this.btnManutencoes.Name = "btnManutencoes";
            this.btnManutencoes.Size = new System.Drawing.Size(185, 23);
            this.btnManutencoes.TabIndex = 5;
            this.btnManutencoes.Text = "Manutenções";
            this.btnManutencoes.UseVisualStyleBackColor = true;
            this.btnManutencoes.Click += new System.EventHandler(this.BtnManutencoes_Click);
            // 
            // btnMultas
            // 
            this.btnMultas.Location = new System.Drawing.Point(361, 102);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(185, 23);
            this.btnMultas.TabIndex = 6;
            this.btnMultas.Text = "Multas";
            this.btnMultas.UseVisualStyleBackColor = true;
            this.btnMultas.Click += new System.EventHandler(this.BtnMultas_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(361, 144);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(185, 23);
            this.btnRelatorios.TabIndex = 7;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // btnViagens
            // 
            this.btnViagens.Location = new System.Drawing.Point(362, 227);
            this.btnViagens.Name = "btnViagens";
            this.btnViagens.Size = new System.Drawing.Size(185, 23);
            this.btnViagens.TabIndex = 8;
            this.btnViagens.Text = "Viagens";
            this.btnViagens.UseVisualStyleBackColor = true;
            this.btnViagens.Click += new System.EventHandler(this.BtnViagens_Click);
            // 
            // btnGaragem
            // 
            this.btnGaragem.Location = new System.Drawing.Point(85, 227);
            this.btnGaragem.Name = "btnGaragem";
            this.btnGaragem.Size = new System.Drawing.Size(166, 23);
            this.btnGaragem.TabIndex = 9;
            this.btnGaragem.Text = "Cadastrar Garagens";
            this.btnGaragem.UseVisualStyleBackColor = true;
            this.btnGaragem.Click += new System.EventHandler(this.BtnGaragem_Click);
            // 
            // btnSaidaEstoque
            // 
            this.btnSaidaEstoque.Location = new System.Drawing.Point(362, 184);
            this.btnSaidaEstoque.Name = "btnSaidaEstoque";
            this.btnSaidaEstoque.Size = new System.Drawing.Size(184, 23);
            this.btnSaidaEstoque.TabIndex = 10;
            this.btnSaidaEstoque.Text = "Estoque Saida";
            this.btnSaidaEstoque.UseVisualStyleBackColor = true;
            this.btnSaidaEstoque.Click += new System.EventHandler(this.BtnSaidaEstoque_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 292);
            this.Controls.Add(this.btnSaidaEstoque);
            this.Controls.Add(this.btnGaragem);
            this.Controls.Add(this.btnViagens);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnMultas);
            this.Controls.Add(this.btnManutencoes);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.brnFinancas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.label1);
            this.Name = "frmInicial";
            this.Text = "Controle de Frota de Veiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button brnFinancas;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnManutencoes;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnViagens;
        private System.Windows.Forms.Button btnGaragem;
        private System.Windows.Forms.Button btnSaidaEstoque;
    }
}

