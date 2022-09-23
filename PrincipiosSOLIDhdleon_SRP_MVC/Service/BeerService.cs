using PrincipiosSOLIDhdleon_SRP_MVC.Models.Db;
using PrincipiosSOLIDhdleon_SRP_MVC.Models.ViewModels;
using PrincipiosSOLIDhdleon_SRP_MVC.Utils;

namespace PrincipiosSOLIDhdleon_SRP_MVC.Service
{
    public class BeerService
    {
        public void Create(BeerViewModel beer) {
            var beerDB = new BeerDb();
            var log = new Log();

            beerDB.Save(beer);
            log.Save($"Se guardó una cerveza. {beer.GetInfo()}");
        }
    }
}
