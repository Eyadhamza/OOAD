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
         GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,Wood.ALDER, Wood.ALDER);

         List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

         if (!matchingGuitars.Any()) {
             Console.WriteLine("Erin, you might like these guitars:");

             foreach  (Guitar guitar in matchingGuitars)
             {
                 GuitarSpec spec = guitar.Spec;
                 Console.WriteLine(" We have a " +
                                   spec.Builder + " " + spec.Model + " " +
                                   spec.Type + " guitar:\n " +
                                   spec.BackWood + " back and sides,\n " +
                                   spec.TopWood + " top.\n You can have it for only $" +
                                   guitar.Price + "!\n ----");
             }

         }
         else
         {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
         }
        }
        private static void InitializeInventory(Inventory inventory) {
            // Add guitars to the inventory...
        }
    }
}
