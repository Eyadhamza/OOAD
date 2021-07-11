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

         properties.Add("builder",Builder.GIBSON);
         properties.Add("backWood",Wood.MAPLE);

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

            properties.Add("instrumentType",InstrumentType.GUITAR);

            properties.Add("builder", Builder.COLLINGS);
            properties.Add("model", "CJ");
            properties.Add("type", Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.SITKA);
            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));

        }
    }
}
