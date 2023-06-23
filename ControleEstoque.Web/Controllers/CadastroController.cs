using ControleEstoque.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class CadastroController : Controller
    {
        private static List<GrupoProdutoModel> _LISTAgRUPOpRODUTO = new List<GrupoProdutoModel>()
        {
            new  GrupoProdutoModel() { Id=1, Nome="Livros", Ativo=true},
            new  GrupoProdutoModel() { Id=2, Nome="Mouses", Ativo=false},
            new  GrupoProdutoModel() { Id=3, Nome="Monitores", Ativo=true}
        };

        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_LISTAgRUPOpRODUTO);
        }
   
        [HttpPost]
        [Authorize]
        public ActionResult RecuperarGrupoProduto(int id)
        {
           return Json(_LISTAgRUPOpRODUTO.Find(x => x.Id == id));
        }


        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }

        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }

        [Authorize]
        public ActionResult Fonercedor()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}