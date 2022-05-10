using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //ActionResult representam os vários códigos HTTP,

        //Códigos HTTP - https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = Reserva de espaço para armazenar informações para recuperar na VIEW.

            //ViewBag = tem a função de "carregar" as informações do Controller para a VIEW.

            ViewBag.Equipes = equipeModel.LerEquipes();
            return View();
        }
    }
}
