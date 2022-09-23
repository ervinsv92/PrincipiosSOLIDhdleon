using Microsoft.AspNetCore.Mvc;
using PrincipiosSOLIDhdleon_SRP_MVC.Models.ViewModels;
using PrincipiosSOLIDhdleon_SRP_MVC.Service;

namespace PrincipiosSOLIDhdleon_SRP_MVC.Controllers
{
    public class BeerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(BeerViewModel beer)
        {
            if (!ModelState.IsValid) {
                return View(beer);
            }

            //guardado de bd
            var beerService = new BeerService();
            beerService.Create(beer);

            //guardado en log, se hace dentro del servicio

            return Ok();
        }
    }
}
