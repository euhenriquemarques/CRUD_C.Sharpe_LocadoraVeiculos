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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "SIS_ADMIN" && txtSenha.Text == "pass")
            {
                MessageBox.Show("OK");

                this.Hide();
                frmInicial form = new frmInicial();
                form.Show();
            }
            else
            {
                if(txtUsuario.Text == "SIS_ADMIN" && txtSenha.Text != "pass")
                {
                    MessageBox.Show("Senha incorreta");
                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                }
                else if(txtUsuario.Text != "SIS_ADMIN" && txtSenha.Text == "pass")
                {
                    MessageBox.Show("Usuário Incorreto");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuário e senha incorretos");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }

            


        }

    
    }
}
