using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PIM1;
using System.Data;

namespace PIM1
{
    public class ClienteDao : DAO
    {

        MySqlCommand comando = null;
        public void Salvar(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO CDCLIENTE (NOME, CPF, RG, ORG_EXP, UF_EXP, CNH, VENCIMENTO_CNH, NASCIMENTO_DATA, ENDERECO, MUNICIPIO, UF, COMPLEMENTO, BAIRRO, NUMERO_ENDERECO, EMAIL, TELEFONE, CELULAR) VALUES (@NOME, @CPF, @RG, @ORG_EXP, @UF_EXP, @CNH, @VENCIMENTO_CNH, @NASCIMENTO_DATA, @ENDERECO, @MUNICIPIO, @UF, @COMPLEMENTO, @BAIRRO, @NUMERO_ENDERECO, @EMAIL, @TELEFONE, @CELULAR)", conexao);
             
                
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@cpf", cliente.CPF);
                comando.Parameters.AddWithValue("@rg", cliente.rg);
                comando.Parameters.AddWithValue("@org_exp", cliente.org_exp);
                comando.Parameters.AddWithValue("@uf_exp", cliente.uf_exp);
                comando.Parameters.AddWithValue("@cnh", cliente.cnh);
                comando.Parameters.AddWithValue("@VENCIMENTO_CNH", cliente.vencimento_cnh);
                comando.Parameters.AddWithValue("@NASCIMENTO_DATA", cliente.nascimento_data);
                comando.Parameters.AddWithValue("@ENDERECO", cliente.endereco);
                comando.Parameters.AddWithValue("@MUNICIPIO", cliente.municipio);
                comando.Parameters.AddWithValue("@UF", cliente.uf);
                comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.complemento);
                comando.Parameters.AddWithValue("@BAIRRO", cliente.bairro);
                comando.Parameters.AddWithValue("@NUMERO_ENDERECO", cliente.numero_endereco);
                comando.Parameters.AddWithValue("@EMAIL", cliente.email);
                comando.Parameters.AddWithValue("@TELEFONE", cliente.telefone);
                comando.Parameters.AddWithValue("@CELULAR", cliente.celular);

                comando.ExecuteNonQuery();
              
            }
            catch (Exception erro)
            {
                throw erro;

            }finally
            {
                FecharConexao();
            }

        }
        
        public DataTable listar()
        {
            try
            {
                AbrirConexao();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                comando = new MySqlCommand("SELECT * FROM CDCLIENTE order by nome", conexao);

                da.SelectCommand = comando;

                da.Fill(dt);

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void editar(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("UPDATE CDCLIENTE SET NOME = @NOME, CPF = @CPF, RG = @RG, ORG_EXP = @ORG_EXP, UF_EXP = @UF_EXP, CNH = @CNH, VENCIMENTO_CNH = @VENCIMENTO_CNH, NASCIMENTO_DATA = @NASCIMENTO_DATA, ENDERECO = @ENDERECO, MUNICIPIO = @MUNICIPIO, UF = @UF, COMPLEMENTO = @COMPLEMENTO, BAIRRO = @BAIRRO, NUMERO_ENDERECO = @NUMERO_ENDERECO, EMAIL = @EMAIL, TELEFONE = @TELEFONE, CELULAR = @CELULAR WHERE CPF = @CPF", conexao);

              
                comando.Parameters.AddWithValue("@nome", cliente.nome);
                comando.Parameters.AddWithValue("@cpf", cliente.CPF);
                comando.Parameters.AddWithValue("@rg", cliente.rg);
                comando.Parameters.AddWithValue("@org_exp", cliente.org_exp);
                comando.Parameters.AddWithValue("@uf_exp", cliente.uf_exp);
                comando.Parameters.AddWithValue("@cnh", cliente.cnh);
                comando.Parameters.AddWithValue("@VENCIMENTO_CNH", cliente.vencimento_cnh);
                comando.Parameters.AddWithValue("@NASCIMENTO_DATA", cliente.nascimento_data);
                comando.Parameters.AddWithValue("@ENDERECO", cliente.endereco);
                comando.Parameters.AddWithValue("@MUNICIPIO", cliente.municipio);
                comando.Parameters.AddWithValue("@UF", cliente.uf);
                comando.Parameters.AddWithValue("@COMPLEMENTO", cliente.complemento);
                comando.Parameters.AddWithValue("@BAIRRO", cliente.bairro);
                comando.Parameters.AddWithValue("@NUMERO_ENDERECO", cliente.numero_endereco);
                comando.Parameters.AddWithValue("@EMAIL", cliente.email);
                comando.Parameters.AddWithValue("@TELEFONE", cliente.telefone);
                comando.Parameters.AddWithValue("@CELULAR", cliente.celular);

                comando.ExecuteNonQuery();

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
        //METODO DE EXCLUIR

        public void excluir(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new MySqlCommand("DELETE FROM CDCLIENTE WHERE CPF=@CPF", conexao);
                comando.Parameters.AddWithValue("@CPF", cliente.CPF);

                comando.ExecuteNonQuery();
               
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
