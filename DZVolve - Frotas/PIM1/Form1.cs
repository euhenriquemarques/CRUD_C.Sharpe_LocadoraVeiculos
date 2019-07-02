using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM1;

namespace PIM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            listar();
        }



        // metodo de salvaar de cliente
        private void salvar(Cliente cliente)
        {
            ClienteBLL clientebll = new ClienteBLL();
            cliente.nome = txbnome.Text;
            cliente.CPF = txbcpf.Text;
            cliente.rg = txbrg.Text;
            cliente.org_exp = txbOe.Text;
            cliente.uf_exp = txbUfexp.Text;
            cliente.cnh = txbcnh.Text;
            cliente.vencimento_cnh = txbVcnh.Text;
            cliente.nascimento_data = txbData.Text;
            cliente.endereco = txbendereco.Text;
            cliente.municipio = txbmunicipio.Text;
            cliente.uf = txbuf.Text;
            cliente.complemento = txbcomplemento.Text;
            cliente.bairro = txbbairro.Text;
            cliente.numero_endereco = txbnumero.Text;
            cliente.email = txbemail.Text;
            cliente.telefone = txbtelefone.Text;
            cliente.celular = txbcelular.Text;

            clientebll.salvar(cliente);

            MessageBox.Show("Cliente salvo com sucesso");
            listar();
        }

        // metodo de listagem de cliente

            private void listar()
        {
            ClienteBLL clientebll = new ClienteBLL();

            bdview.DataSource = clientebll.listar();
        }


        //editando
        private void editar(Cliente cliente)
        {
            ClienteBLL clientebll = new ClienteBLL();
            cliente.nome = txbnome.Text;
            cliente.CPF = txbcpf.Text;
            cliente.rg = txbrg.Text;
            cliente.org_exp = txbOe.Text;
            cliente.uf_exp = txbUfexp.Text;
            cliente.cnh = txbcnh.Text;
            cliente.vencimento_cnh = txbVcnh.Text;
            cliente.nascimento_data = txbData.Text;
            cliente.endereco = txbendereco.Text;
            cliente.municipio = txbmunicipio.Text;
            cliente.uf = txbuf.Text;
            cliente.complemento = txbcomplemento.Text;
            cliente.bairro = txbbairro.Text;
            cliente.numero_endereco = txbnumero.Text;
            cliente.email = txbemail.Text;
            cliente.telefone = txbtelefone.Text;
            cliente.celular = txbcelular.Text;

            clientebll.editar(cliente);
            MessageBox.Show("Cliente editado com sucesso!");
            listar();

        }

        //Metodo de excluir cliente

            private void excluir(Cliente cliente)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            cliente.CPF = txbcpf.Text;
            clienteBLL.excluir(cliente);

            MessageBox.Show("Cliente removido do Banco com sucesso!");
            listar();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txbnome.Enabled = true;
            txbcpf.Enabled = true;
            txbuf.Enabled = true;
            txbemail.Enabled = true;
            txbmunicipio.Enabled = true;
            txbendereco.Enabled = true;
            txbbairro.Enabled = true;
            txbnumero.Enabled = true;
            txbcomplemento.Enabled = true;
            txbtelefone.Enabled = true;
            txbcelular.Enabled = true;
            txbcnh.Enabled = true;
            txbData.Enabled = true;
            txbOe.Enabled = true;
            txbrg.Enabled = true;
            txbUfexp.Enabled = true;
            txbVcnh.Enabled = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txbnome.Enabled = true;
            txbcpf.Enabled = true;
            txbuf.Enabled = true;
            txbemail.Enabled = true;
            txbmunicipio.Enabled = true;
            txbendereco.Enabled = true;
            txbbairro.Enabled = true;
            txbnumero.Enabled = true;
            txbcomplemento.Enabled = true;
            txbtelefone.Enabled = true;
            txbcelular.Enabled = true;
            txbcnh.Enabled = false;
            txbData.Enabled = false;
            txbOe.Enabled = false;
            txbrg.Enabled = false;
            txbUfexp.Enabled = false;
            txbVcnh.Enabled = false;
            
        }

    
        private void Button2_Click(object sender, EventArgs e)
        {
            if (testaDados() == true)
            {
                Cliente cliente = new Cliente();
                salvar(cliente);
            }
            else
            {
                MessageBox.Show("Erro");
            }
         
        }
        public bool testaDados()
        {
            if (String.IsNullOrEmpty(txbnome.Text) || txbnome.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Nome", "Nome");
                return false;
            }
            if (String.IsNullOrEmpty(txbcnh.Text) || !txbcnh.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo CNH", "CNH");
                return false;
            }
            if (String.IsNullOrEmpty(txbData.Text))
            {
                MessageBox.Show("Erro no campo Data", "Data");
                return false;
            }
            if (String.IsNullOrEmpty(txbendereco.Text))
            {
                MessageBox.Show("Erro no campo Endereço", "Endereço");
                return false;
            }
            if (String.IsNullOrEmpty(txbmunicipio.Text) || txbmunicipio.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Municipio", "Municipio");
                return false;
            }
            if (String.IsNullOrEmpty(txbtelefone.Text) || !txbtelefone.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Telefone", "Telefone");
                return false;
            }
            if (String.IsNullOrEmpty(txbcpf.Text) || !txbcpf.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo CPF", "CPF");
                return false;
            }
            if (String.IsNullOrEmpty(txbVcnh.Text))
            {
                MessageBox.Show("Erro no campo Vencimento CNH", "Vencimento CNH");
                return false;
            }
            if (String.IsNullOrEmpty(txbnumero.Text) || !txbnumero.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Número", "Número");
                return false;
            }
            if (String.IsNullOrEmpty(txbbairro.Text))
            {
                MessageBox.Show("Erro no campo Bairro", "Bairro");
                return false;
            }
            if (String.IsNullOrEmpty(txbuf.Text) || txbuf.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo UF", "UF");
                return false;
            }
            if (String.IsNullOrEmpty(txbcelular.Text) || !txbcelular.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Celular", "Celular");
                return false;
            }
            if (String.IsNullOrEmpty(txbrg.Text))
            {
                MessageBox.Show("Erro no campo RG", "RG");
                return false;
            }
            if (String.IsNullOrEmpty(txbOe.Text) || txbOe.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo Orgão Expeditor", "Orgão Expeditor");
                return false;
            }
            if (String.IsNullOrEmpty(txbUfexp.Text) || txbUfexp.Text.All(char.IsNumber))
            {
                MessageBox.Show("Erro no campo UF Expeditor", "UF Expeditor");
                return false;
            }
            if (String.IsNullOrEmpty(txbcomplemento.Text))
            {
                MessageBox.Show("Erro no campo Complemento", "Complemento");
                return false;
            }
            if (String.IsNullOrEmpty(txbemail.Text))
            {
                MessageBox.Show("Erro no campo E-mail", "E-mail");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Bdview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbnome.Text = bdview.CurrentRow.Cells[0].Value.ToString();
            txbcpf.Text = bdview.CurrentRow.Cells[1].Value.ToString();
            txbrg.Text = bdview.CurrentRow.Cells[2].Value.ToString();
            txbOe.Text = bdview.CurrentRow.Cells[3].Value.ToString();
            txbUfexp.Text = bdview.CurrentRow.Cells[4].Value.ToString();
            txbcnh.Text = bdview.CurrentRow.Cells[5].Value.ToString();
            txbVcnh.Text = bdview.CurrentRow.Cells[6].Value.ToString();
            txbData.Text = bdview.CurrentRow.Cells[7].Value.ToString();
            txbendereco.Text = bdview.CurrentRow.Cells[8].Value.ToString();
            txbmunicipio.Text = bdview.CurrentRow.Cells[9].Value.ToString();
            txbuf.Text = bdview.CurrentRow.Cells[10].Value.ToString();
            txbcomplemento.Text = bdview.CurrentRow.Cells[11].Value.ToString();
            txbbairro.Text = bdview.CurrentRow.Cells[12].Value.ToString();
            txbnumero.Text = bdview.CurrentRow.Cells[13].Value.ToString();
            txbemail.Text = bdview.CurrentRow.Cells[14].Value.ToString();
            txbtelefone.Text = bdview.CurrentRow.Cells[15].Value.ToString();
            txbcelular.Text = bdview.CurrentRow.Cells[16].Value.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (testaDados() == true)
            {
                Cliente cliente = new Cliente();
                editar(cliente);
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            excluir(cliente);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txbbairro.Text = "";
            txbcelular.Text = "";
            txbcnh.Text = "";
            txbcomplemento.Text = "";
            txbcpf.Text = "";
            txbData.Text = "";
            txbemail.Text = "";
            txbendereco.Text = "";
            txbmunicipio.Text = "";
            txbnome.Text = "";
            txbnumero.Text = "";
            txbOe.Text = "";
            txbrg.Text = "";
            txbtelefone.Text = "";
            txbuf.Text = "";
            txbUfexp.Text = "";
            txbVcnh.Text = "";

        }
    }
}

