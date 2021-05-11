using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public string Idade { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public List<Usuario> Lista()
        {
            var lista = new List<Usuario>();
            var usuarioDb = new BancoDados.Usuario();
            {
                foreach (DataRow row in usuarioDb.Lista().Rows)
                {
                    var usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(row["id"]);
                    usuario.Nome = row["nome"].ToString();
                    usuario.Telefone = row["telefone"].ToString();
                    usuario.Rg = row["rg"].ToString();
                    usuario.Cpf = row["cpf"].ToString();
                    usuario.DataNascimento = Convert.ToDateTime(row["datanascimento"]);            
                    usuario.DataCadastro = Convert.ToDateTime(row["datacadastro"]);
                    usuario.Idade = row["idade"].ToString();
                    usuario.Sexo = row["sexo"].ToString();
                    usuario.Email = row["email"].ToString();
                    usuario.Senha = row["senha"].ToString();
                    usuario.Cep = row["cep"].ToString();
                    usuario.Endereco = row["endereco"].ToString();
                    usuario.Bairro = row["bairro"].ToString();
                    usuario.Cidade = row["cidade"].ToString();
                    usuario.Estado = row["estado"].ToString();

                    lista.Add(usuario);
                }
                return lista;
            }
        }

        public void Save()
        {
            new BancoDados.Usuario().Salvar(this.Id, this.Nome, this.Telefone, this.Rg, this.Cpf, this.DataNascimento, this.DataCadastro,
                this.Idade, this.Sexo, this.Email, this.Senha, this.Cep, this.Endereco, this.Bairro, this.Cidade, this.Estado );
        }

        public static void Excluir(int id)
        {
            new BancoDados.Usuario().Excluir(id);
        }

        public static Usuario BuscaPorId(int id)
        {
            var usuario = new Usuario();
            var usuarioDb = new BancoDados.Usuario();
            {
                foreach (DataRow row in usuarioDb.BuscaPorId(id).Rows)
                {

                    usuario.Id = Convert.ToInt32(row["id"]);
                    usuario.Nome = row["nome"].ToString();
                    usuario.Telefone = row["telefone"].ToString();
                    usuario.Rg = row["rg"].ToString();
                    usuario.Cpf = row["cpf"].ToString();
                    usuario.DataNascimento = Convert.ToDateTime(row["datanascimento"]);
                    usuario.DataCadastro = Convert.ToDateTime(row["datacadastro"]);
                    usuario.Idade = row["idade"].ToString();
                    usuario.Sexo = row["sexo"].ToString();
                    usuario.Email = row["email"].ToString();
                    usuario.Senha = row["senha"].ToString();
                    usuario.Cep = row["cep"].ToString();
                    usuario.Endereco = row["endereco"].ToString();
                    usuario.Bairro = row["bairro"].ToString();
                    usuario.Cidade = row["cidade"].ToString();
                    usuario.Estado = row["estado"].ToString();


                }
                return usuario;
            }
        }
    }
}
