﻿using System.Collections.Generic;

namespace chapter1_Guitars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor",
                                              Type.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars.Any())
            {
                Console.WriteLine("Erin, you might like these guitars:");
                for (int i = 0; i< matchingGuitars.Count; i++)
                {
                    Guitar guitar = matchingGuitars[i];
                    GuitarSpec spec = guitar.getSpec();
                    Console.WriteLine("  We have a " +
                      spec.getBuilder() + " " + spec.getModel() + " " +
                      spec.getType() + " guitar:\n     " +
                      spec.getBackWood() + " back and sides,\n     " +
                      spec.getTopWood() + " top.\n  You can have it for only $" +
                      guitar.getPrice() + "!\n  ----");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }
        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("11277", 3999.95,
     new GuitarSpec(Builder.COLLINGS, "CJ", Type.ACOUSTIC,
                    Wood.INDIAN_ROSEWOOD, Wood.SITKA));
            inventory.addGuitar("V95693", 1499.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,
                             Wood.ALDER, Wood.ALDER));
            inventory.addGuitar("V9512", 1549.95,
              new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC,
                             Wood.ALDER, Wood.ALDER));
            inventory.addGuitar("122784", 5495.95,
              new GuitarSpec(Builder.MARTIN, "D-18", Type.ACOUSTIC,
                             Wood.MAHOGANY, Wood.ADIRONDACK));
            inventory.addGuitar("76531", 6295.95,
              new GuitarSpec(Builder.MARTIN, "OM-28", Type.ACOUSTIC,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.addGuitar("70108276", 2295.95,
              new GuitarSpec(Builder.GIBSON, "Les Paul", Type.ELECTRIC,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.addGuitar("82765501", 1890.95,
              new GuitarSpec(Builder.GIBSON, "SG '61 Reissue", Type.ELECTRIC,
                             Wood.MAHOGANY, Wood.MAHOGANY));
            inventory.addGuitar("77023", 6275.95,
              new GuitarSpec(Builder.MARTIN, "D-28", Type.ACOUSTIC,
                             Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK));
            inventory.addGuitar("1092", 12995.95,
              new GuitarSpec(Builder.OLSON, "SJ", Type.ACOUSTIC,
                             Wood.INDIAN_ROSEWOOD, Wood.CEDAR));
            inventory.addGuitar("566-62", 8999.95,
              new GuitarSpec(Builder.RYAN, "Cathedral", Type.ACOUSTIC,
                             Wood.COCOBOLO, Wood.CEDAR));
            inventory.addGuitar("6 29584", 2100.95,
              new GuitarSpec(Builder.PRS, "Dave Navarro Signature", Type.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE));
        }
    }
}
