using GuitarApp1.Models;
using System.Reflection;
using GuitarApp1.Models;
internal class Program
{

    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        InitializeInventory(inventory);

        //examples you can try
        //GuitarSpecs NishaLikes = new GuitarSpecs(Builder.Any, null, GuitarApp1.Models.Type.Accoustic, Wood.Alder, Wood.Alder, 6);

        //examples you can try
        //GuitarSpecs NishaLikes = new GuitarSpecs(Builder.Any, null, GuitarApp1.Models.Type.Accoustic, Wood.BrazilianRosewood, Wood.Maple, 6);

        //examples you can try
        GuitarSpecs NishaLikes = new GuitarSpecs(Builder.Any, null, GuitarApp1.Models.Type.Electric, Wood.Alder, Wood.Maple, 6);

        List<Guitar> matchingGuitars = inventory.SearchGuitar(NishaLikes);
        if (matchingGuitars.Count > 0)
        {
            Console.WriteLine("Nisha, you must try these guitars:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"Builder",-10} | {"Model",-15} | {"Type",-10} | {"BackWood",-10} | {"TopWood",-10} | {"No. of Strings",-15} | {"Price",-8}|");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            foreach (var guitar in matchingGuitars)
            {

                Console.WriteLine($"|{guitar.Spec.Builder,-10} | {guitar.Spec.Model,-15} | {guitar.Spec.Type,-10} | {guitar.Spec.BackWood,-10} | {guitar.Spec.TopWood,-10} | {guitar.Spec.NumberOfStrings,-15} | {guitar.Price,-8}|");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");
            }
        }
        else
        {
            Console.WriteLine(" Nisha, we have nothing for u.");
        }
    }

    private static void InitializeInventory(Inventory inventory)
    {
        inventory.AddGuitar("1", 4000, new GuitarSpecs(Builder.Collings, "CJ", GuitarApp1.Models.Type.Accoustic, Wood.Alder, Wood.Alder, 6));
        inventory.AddGuitar("2", 2000, new GuitarSpecs(Builder.Fender, "Stratocaster", GuitarApp1.Models.Type.Electric, Wood.Alder, Wood.Alder, 6));
        inventory.AddGuitar("3", 1149.50, new GuitarSpecs(Builder.Gibson, "Stratocaster", GuitarApp1.Models.Type.Accoustic, Wood.BrazilianRosewood, Wood.Alder, 6));
        inventory.AddGuitar("4", 7500, new GuitarSpecs(Builder.Ryan, "Yamaha", GuitarApp1.Models.Type.Electric, Wood.Alder, Wood.Maple, 6));
        inventory.AddGuitar("5", 2000, new GuitarSpecs(Builder.Fender, "Stratocaster", GuitarApp1.Models.Type.Accoustic, Wood.Alder, Wood.Alder, 6));

    }
}
