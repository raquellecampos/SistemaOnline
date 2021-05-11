using Estrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SistemaOnline_CadastroAluno.Controllers
{
    public class UsuarioController:Controller
    {
        public ActionResult Index()
        {

            ViewBag.Usuarios = new Usuario().Lista();  //lista do banco de dados

            return View();
        }

        public ActionResult Novo()  //novo cadastro
        {
            return View();
        }

        [HttpPost]
        public void Criar()
        {
            DateTime datanascimento;
            DateTime.TryParse(Request["datanascimento"], out datanascimento);

            DateTime datacadastro;
            DateTime.TryParse(Request["datacadastro"], out datacadastro);

           var usuario = new Usuario(); //objeto
            usuario.Nome = Request["nome"];
            usuario.Telefone = Request["telefone"];
            usuario.Rg = Request["rg"];
            usuario.Cpf = Request["cpf"];
            usuario.DataNascimento = datanascimento;
            usuario.DataCadastro = datacadastro;
            usuario.Idade = Request["idade"];
            usuario.Sexo = Request["sexo"];
            usuario.Email = Request["email"];
            usuario.Senha = Request["senha"];
            usuario.Cep = Request["cep"];
            usuario.Endereco = Request["endereco"];
            usuario.Bairro = Request["bairro"];
            usuario.Cidade = Request["cidade"];
            usuario.Estado = Request["estado"];
            
            
            usuario.Save();
            Response.Redirect("/usuario");
        }

        public void Excluir(int id)
        {
            Usuario.Excluir(id);
            Response.Redirect("/usuario");
        }


        public ActionResult Editar(int id)
        {
            var usuario = Usuario.BuscaPorId(id);
            ViewBag.Usuarios = usuario;
            return View();
        }

        [HttpPost]
        public void Alterar(int id)
        {
            try
            {
                var usuario = Usuario.BuscaPorId(id);

                DateTime datanascimento;
                DateTime.TryParse(Request["datanascimento"], out datanascimento);

                DateTime datacadastro;
                DateTime.TryParse(Request["datacadastro"], out datacadastro);

                usuario.Nome = Request["nome"];
                usuario.Telefone = Request["telefone"];
                usuario.Rg = Request["rg"];
                usuario.Cpf = Request["cpf"];
                usuario.DataNascimento = datanascimento;
                usuario.DataCadastro = datacadastro;
                usuario.Idade = Request["idade"];
                usuario.Sexo = Request["sexo"];
                usuario.Email = Request["email"];
                usuario.Senha = Request["senha"];
                usuario.Cep = Request["cep"];
                usuario.Endereco = Request["endereco"];
                usuario.Bairro = Request["bairro"];
                usuario.Cidade = Request["cidade"];
                usuario.Estado = Request["estado"];

                usuario.Save();

                TempData["Sucesso"] = "Cadastro alterado com sucesso";

                Response.Redirect("/usuario");
            }
            catch
            {
                TempData["Erro"] = "Falha ao tentar alterar cadastro!";
            }

        }

    }
}

