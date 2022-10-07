//SOLID - O - Principio de abierto/cerrado OCP
/*
    Abierto para su extensión pero cerrado para su modificación
 */

//La clase ya no se usaria, ahora se usa la interface
public class Drink { 
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
}

public interface IDrink { 
    public string Name { get; set; }

    //El tipo ya no se ocupa
    //public string Type { get; set; }
    public decimal Price { get; set; }
    public decimal Invoice { get; set; }

    public decimal GetPrice();

    //public decimal GetPrice() {
    //    return Price * Invoice;
    //}
}

public class Water : IDrink {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal Invoice { get; set; }
    public decimal GetPrice() {
        return Price * Invoice;
    }
}

public class Alcohol : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal Invoice { get; set; }
    public decimal Promo { get; set; }
    public decimal GetPrice()
    {
        return (Price * Invoice)-Promo;
    }
}

public class Sugary : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal Invoice { get; set; }
    public decimal Expiration { get; set; }
    public decimal GetPrice()
    {
        return (Price * Invoice) - Expiration;
    }
}

//Se agrega un nuevo tipo de bebida
public class Energizing : IDrink
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public decimal Invoice { get; set; }
    public decimal GetPrice()
    {
        return (Price * Invoice);
    }
}

public class Invoice {

    public decimal GetTotal(IEnumerable<IDrink> lstDrink) {
        decimal total = 0;

        foreach (var drink in lstDrink)
        {

            total += drink.GetPrice();

            //Codigo viejo
            //if (drink.Type == "Agua") {
            //    total += drink.Price;
            //} else if (drink.Type == "Azucar") {
            //    total += drink.Price * 0.33m;
            //}
            //else if (drink.Type == "Alcohol")
            //{
            //    total += drink.Price * 0.14m;
            //}
            //else if (drink.Type == "Energizante")
            //{
            //    total += drink.Price * 0.1788m;
            //}

        }
        return total;
    }
}