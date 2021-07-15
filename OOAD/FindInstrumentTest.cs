using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOAD
{
    public class FindInstrumentTest
    {
        public static void Main(String[] args) {

         // Set up Rick’s instrument inventory
         Inventory inventory = new Inventory();
         InitializeInventory(inventory);

         Hashtable properties = new Hashtable();

         properties.Add("builder",Builder.COLLINGS);
         properties.Add("backWood",Wood.SITKA);

         InstrumentSpec whatErinLikes = new InstrumentSpec(properties);

         List<Instrument> matchingInstruments = inventory.Search(whatErinLikes);

         if (matchingInstruments.Any()) {
             Console.WriteLine("Erin, you might like these instruments:");

             foreach  (Instrument instrument in matchingInstruments)
             {
                 Console.WriteLine(instrument);
                 InstrumentSpec spec = instrument.Spec;
                 Console.WriteLine("We have a " + spec.GetPropertyValue("instrumentType") + "with the following properties");

                 foreach (var propertyName in spec.GetPropertiesKeys())
                 {
                     if (propertyName.ToString() == "instrumentType")
                     {
                      continue;
                     }
                     Console.WriteLine(" You can have this " + spec.GetPropertyValue("instrumentType") + " for $" +
                         instrument.Price + "\n---");

                 }

             }

         }
         else
         {
            Console.WriteLine("Sorry, Erin, we have nothing for you.");
         }
        }
        private static void InitializeInventory(Inventory inventory)
        {
            Hashtable properties = new Hashtable();
            properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("builder", Builder.COLLINGS);
            properties.Add("model", "CJ");
            properties.Add("type", Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.SITKA);
            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));

            Hashtable properties2 = new Hashtable();
            properties2.Add("builder", Builder.MARTIN);
            properties2.Add("model", "D-18");
            properties2.Add("topWood", Wood.MAHOGANY);
            properties2.Add("backWood", Wood.ADIRONDACK);
            inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties2));

            Hashtable properties3 = new Hashtable();
            properties3.Add("builder", Builder.FENDER);
            properties3.Add("model", "Stratocastor");
            properties3.Add("type", Type.ELECTRIC);
            properties3.Add("topWood", Wood.ALDER);
            properties3.Add("backWood", Wood.ALDER);
            inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties3));

            inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties3));

            Hashtable properties4 = new Hashtable();
            properties4.Add("builder", Builder.GIBSON);
            properties4.Add("model", "Les Paul");
            properties4.Add("topWood", Wood.MAPLE);
            properties4.Add("backWood", Wood.MAPLE);
            inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties4));

            Hashtable properties5 = new Hashtable();
            properties5.Add("model", "SG ‘61 Reissue");
            properties5.Add("topWood", Wood.MAHOGANY);
            properties5.Add("backWood", Wood.MAHOGANY);
            inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(properties5));

            Hashtable properties6 = new Hashtable();
            properties6.Add("instrumentType", InstrumentType.MANDOLIN);
            properties6.Add("type", Type.ACOUSTIC);
            properties6.Add("model", "F-5G");
            properties6.Add("backWood", Wood.MAPLE);
            properties6.Remove("numStrings");
            inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(properties6));

        }
    }
}
