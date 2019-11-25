using System.Collections.Generic;
using System;

namespace handleplan
{
    public class DinnerData
    {
        public List<Dinner> dinners;

        public void printData()
        {
            for (int i = 0; i < dinners.Count; i++)
            {
                Console.WriteLine(i + ": " + dinners[i].title);
            }
        }

        public DinnerData()
        {
            dinners = new List<Dinner>
            {
                new Dinner("Frokost", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Rundstykke6pk, 0.33),
                    new Ingredient((int) Ingredients.Egg6pk, 0.33),
                    new Ingredient((int) Ingredients.Ost, 0.05),
                    new Ingredient((int) Ingredients.SalamiPakke, 0.1),
                    new Ingredient((int) Ingredients.RekeSalat, 0.25),
                    new Ingredient((int) Ingredients.Kaffe, 0.05),
                }),

                new Dinner("Lasagne", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Kjøttdeig, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.LasagnePakke, 1),
                    new Ingredient((int) Ingredients.Melk, 0.5),
                    new Ingredient((int) Ingredients.Ost, 0.10),
                }),

                new Dinner("Pølse & Potetstappe", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.PotetKg, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.125),
                    new Ingredient((int) Ingredients.Melk, 0.5),
                    new Ingredient((int) Ingredients.Servelat, 1),
                }),

                new Dinner("Kjøttboller/saus & Potetstappe", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.PotetKg, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.125),
                    new Ingredient((int) Ingredients.Melk, 0.5),
                    new Ingredient((int) Ingredients.Kjøttboller, 0.5),
                    new Ingredient((int) Ingredients.SausPakke, 1),
                }),
                
                new Dinner("Pasta Carbonara", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Bacon, 2),
                    new Ingredient((int) Ingredients.TagliatellePakke, 0.5),
                    new Ingredient((int) Ingredients.Fløte, 0.2),
                    new Ingredient((int) Ingredients.ErterPk, 0.2),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.Hvitløk, 0.05),
                    new Ingredient((int) Ingredients.Egg6pk, 0.167),
                }),

                new Dinner("Taco", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Falafel, 1),
                    new Ingredient((int) Ingredients.Salat, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.Mais3pk, 0.33),
                    new Ingredient((int) Ingredients.Paprika, 1),
                    new Ingredient((int) Ingredients.Tomater, 0.5),
                    new Ingredient((int) Ingredients.TacoLefse, 1),
                    new Ingredient((int) Ingredients.Salsa, 0.3),
                    new Ingredient((int) Ingredients.Ost, 0.05),
                    new Ingredient((int) Ingredients.Rømme, 0.2),
                }),

                new Dinner("Pizza", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Mel, 0.4),
                    new Ingredient((int) Ingredients.Gjær, 0.2),
                    new Ingredient((int) Ingredients.Kjøttdeig, 1),
                    new Ingredient((int) Ingredients.Ananas3pk, 0.33),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.HakketTomat, 1),
                    new Ingredient((int) Ingredients.Hvitløk, 0.05),
                    new Ingredient((int) Ingredients.Ost, 0.2),
                    new Ingredient((int) Ingredients.Rømme, 0.2),
                }),

                new Dinner("Nachos", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Kjøttdeig, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.Hvitløk, 0.05),
                    new Ingredient((int) Ingredients.Ost, 0.2),
                    new Ingredient((int) Ingredients.Rømme, 0.2),
                    new Ingredient((int) Ingredients.Paprika, 1),
                }),

                new Dinner("Enchilladas", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.Kjøttdeig, 1),
                    new Ingredient((int) Ingredients.Løk4pk, 0.25),
                    new Ingredient((int) Ingredients.Hvitløk, 0.05),
                    new Ingredient((int) Ingredients.HakketTomat, 1),
                    new Ingredient((int) Ingredients.Ost, 0.2),
                    new Ingredient((int) Ingredients.Rømme, 0.2),
                    new Ingredient((int) Ingredients.TacoLefse, 1),
                    new Ingredient((int) Ingredients.Salsa, 0.5),
                    new Ingredient((int) Ingredients.Paprika, 1),
                }),

                new Dinner("Fløtepotet & Vossakorv", new List<Ingredient>
                {
                    new Ingredient((int) Ingredients.PotetKg, 0.8),
                    new Ingredient((int) Ingredients.Hvitløk, 0.05),
                    new Ingredient((int) Ingredients.Løk4pk, 0.125),
                    new Ingredient((int) Ingredients.Fløte, 1),
                    new Ingredient((int) Ingredients.Ost, 0.10),
                    new Ingredient((int) Ingredients.Vossakorv, 1),
                }),

                // new Dinner("<>", new List<Ingredient>
                // {
                //     new Ingredient((int) Ingredients., ),
                // }),
            };
        }
    }
}