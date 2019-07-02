using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM1
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 cliente = new Form1();
            cliente.Show();
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmCadVeiculos veiculos = new frmCadVeiculos();
            veiculos.Show();
        }

        private void BrnFinancas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmFinancas financas = new frmFinancas();
            financas.Show();
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Entrada eEntrada = new Entrada();
            eEntrada.Show();
        }

        private void BtnGaragem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmGaragem garagem = new frmGaragem();
            garagem.Show();
        }

        private void BtnManutencoes_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmManutencoes manutencao = new frmManutencoes();
            manutencao.Show();
        }

        private void BtnMultas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Multas multas = new Multas();
            multas.Show();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.Show();
        }

        private void BtnViagens_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmViagens viagens = new frmViagens();
            viagens.Show();
        }

        private void BtnSaidaEstoque_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Saidaa eSaida = new Saidaa();
            eSaida.Show();
        }
    }
}
