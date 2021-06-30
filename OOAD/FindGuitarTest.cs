using System;
using System.Collections.Generic;
using System.Linq;

namespace OOAD
{
    public class FindGuitarTest
    {
        public static void Main(String[] args) {

         // Set up Rick’s guitar inventory
         Inventory inventory = new Inventory();
         InitializeInventory(inventory);
         GuitarSpec whatErinLikes = new GuitarSpec(10,Builder.FENDER, "Stratocastor", Type.ELECTRIC,Wood.ALDER, Wood.ALDER);

         List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

         if (matchingGuitars.Any()) {
             Console.WriteLine("Erin, you might like these guitars:");

             foreach  (Guitar guitar in matchingGuitars)
             {
                 GuitarSpec spec = guitar.Spec;
                 Console.WriteLine(" We have a " +
                                   spec.Builder.Value() + " " + spec.Model + " " +
                                   spec.Type.Value() + " guitar:\n " +
                                   spec.BackWood.Value() + " back and sides,\n " +
                                   spec.TopWood.Value() + " top.\n You can have it for only $" +
                                   guitar.Price + "!\n ----");
             }

         }
         else
         {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
         }
        }
        private static void InitializeInventory(Inventory inventory) {
            inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
        }
    }
}
