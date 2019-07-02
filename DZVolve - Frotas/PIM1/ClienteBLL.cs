using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM1;
using System.Data;

namespace PIM1
{
    public class ClienteBLL
    {
        ClienteDao clientedao = new ClienteDao();
        
        
        // salvar
        public void salvar(Cliente cliente)
        {
            try
            {
                clientedao.Salvar(cliente);

            }catch(Exception erro)
            {
                throw erro;
            }
        }

        // metodo para listar


        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = clientedao.listar();

                return dt;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }


        // editando os dados
        public void editar(Cliente cliente)
        {
            try
            {
                clientedao.editar(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        //excluindo cliente
        public void excluir(Cliente cliente)
        {
            try
            {
                clientedao.excluir(cliente);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
