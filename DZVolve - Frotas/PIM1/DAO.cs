using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace PIM1
{
    public class DAO
    {
        string conectaBanco = "DATABASE=pim; SERVER=127.0.0.1; UID=root; PWD=@morcego1";

       protected MySqlConnection conexao = null;
  

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                conexao.Open();


            }
            catch(Exception erro)
            {
                throw erro;
            }
            
        } 

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                conexao.Close();


            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }
    }
}
