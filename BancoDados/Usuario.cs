using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    public class Usuario
    {
        private string SqlConnection()
        {
            return ConfigurationManager.AppSettings["SqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(SqlConnection()))
            {
                string queryString = "select * from usuariostb";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Salvar(int id, string nome, string telefone, string rg, string cpf, DateTime datanascimento, DateTime datacadastro, string idade,
            string sexo, string email, string senha, string cep, string endereco, string bairro, string cidade, string estado)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnection()))
            {
                string queryString = "insert into usuariostb(nome,telefone,rg,cpf,datanascimento,datacadastro,idade,sexo,email,senha,cep,endereco," +
                    "bairro,cidade,estado) Values('" + nome + "','" + telefone + "', '"+ rg + "', '"+ cpf + "', '" + datanascimento.ToString("yyyy-MM-dd") + "', '" + datacadastro.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + idade + "', '" + sexo + "'," +
                    " '" + email + "', '" + senha + "', '" + cep + "', '" + endereco + "', '" + bairro + "', '" + cidade + "', '" + estado + "')";
                if (id != 0)
                {
                    queryString = "update usuariostb set nome='" + nome + "',telefone='" + telefone + "',rg='"+ rg + "',cpf='" + cpf + "',datanascimento='" + datanascimento.ToString("yyyy-MM-dd") + "',datacadastro='" + datacadastro.ToString("yyyy-MM-dd HH:mm:ss") + "',idade='" + idade + "',sexo='" + sexo + "',email='" + email + "'," +
                        "senha='" + senha + "',cep='" + cep + "',endereco='" + endereco + "',bairro='" + bairro + "',cidade='" + cidade + "',estado='" + estado + "' where id=" + id;
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnection()))
            {

                string queryString = "delete from usuariostb where id=" + id;

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable BuscaPorId(int id)

        {
            using (SqlConnection connection = new SqlConnection(SqlConnection()))
            {
                string queryString = "select * from usuariostb where id=" + id;
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}