﻿namespace PrincipiosSOLIDhdleon_SRP_MVC.Models.ViewModels
{
    public class BeerViewModel
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public string GetInfo() => $"{Name} {Brand}";
    }
}
