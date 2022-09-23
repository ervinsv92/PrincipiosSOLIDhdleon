using PrincipiosSOLIDhdleon_SRP_MVC.Models.ViewModels;

namespace PrincipiosSOLIDhdleon_SRP_MVC.Models.Db
{
    public class BeerDb
    {
        public void Save(BeerViewModel beer) {
            Console.WriteLine($"Guardar en BD {beer.Name}");
        }
    }
}
