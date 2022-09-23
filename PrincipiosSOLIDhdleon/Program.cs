// See https://aka.ms/new-console-template for more information

//SOLID - S - Principio de responsabilidad unica SRP
/*
    Una clase solo debe tener una única responsabilidad

 */
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

public class Beer { 

    //Primera responsabilidad, tener la informacion
    public string Name { get; set; }
    public string Brand { get; set; }

    //Si se ocupa un atributo solo se agrega en esta clase sin afectar las demas
    public string Alochol { get; set; }

    public Beer(string Name, string Brand) {
        this.Name = Name;
        this.Brand = Brand;
    }

    //Segunda responsabilidad, tener metodos, esto se tiene que quitar de aqui
    //public void Save() {
    //    Console.WriteLine($"Guardamos {Name} y {Brand}");
    //}

    //public void Send()
    //{
    //    Console.WriteLine($"Enviamos {Name} y {Brand}");
    //}
}

public class BeerDB{
    private Beer _beer;
    public BeerDB(Beer beer) { 
        this._beer = beer;
    }
    //Esta clase solo se encarga de guardar la informacion
    public void Save()
    {
        Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
    }
}

public class BeerRequest
{
    private Beer _beer;
    public BeerRequest(Beer beer)
    {
        this._beer = beer;
    }

    //Esta clase solo se encarga de enviar la informacion
    public void Send()
    {
        Console.WriteLine($"Enviamos {_beer.Name} y {_beer.Brand}");
    }
}