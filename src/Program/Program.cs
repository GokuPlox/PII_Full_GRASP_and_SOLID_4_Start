//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        //private static List<Product> productCatalog = new List<Product>();

       // private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void Main(string[] args)
        {
            PopulateCatalogs();

            Recipe recipe = new Recipe();
            recipe.FinalProduct = Catalogo.GetProduct("Café con leche");
            recipe.AddStep(Catalogo.GetProduct("Café"), 100, Catalogo.GetEquipment("Cafetera"), 120);
            recipe.AddStep(Catalogo.GetProduct("Leche"), 200, Catalogo.GetEquipment("Hervidor"), 60);

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }

        private static void PopulateCatalogs()
        {
            Catalogo.AddProductToCatalog("Café", 100);
            Catalogo.AddProductToCatalog("Leche", 200);
            Catalogo.AddProductToCatalog("Café con leche", 300);

            Catalogo.AddEquipmentToCatalog("Cafetera", 1000);
            Catalogo.AddEquipmentToCatalog("Hervidor", 2000);
        }
    }
}
