using System.Collections.Generic;
using System;

namespace handleplan
{
    class Program
    {
        static void Main(string[] args)
        {
            DinnerData dinnerData = new DinnerData();
            FoodData foodData = new FoodData();

            Dictionary<string, int> middager = new Dictionary<string, int>();

            string input = "";
            int nrMiddager = 0;

            while (input != "exit")
            {
                Console.Clear();
                Console.WriteLine("\nMiddagsvalg:");
                Console.WriteLine("-------------------\n");
                dinnerData.printData();


                Console.WriteLine("\nMiddager (" + nrMiddager + "):");
                Console.WriteLine("-------------------\n");
                foreach (KeyValuePair<string, int> middag in middager)
                {
                    Console.WriteLine(middag.Key + ": " + middag.Value);
                }

                printPrice(middager, dinnerData, foodData);

                Console.SetCursorPosition(0, Console.WindowHeight);
                Console.Write("Legg til middag: ");
                input = Console.ReadLine();

                String[] arguments = input.Split(' ');
                int nr = Int32.Parse(arguments[0]);
                int dinnerIndex = Int32.Parse(arguments[1]);

                Dinner matValg = dinnerData.dinners[dinnerIndex];
                nrMiddager += nr;
                if (!middager.ContainsKey(matValg.title))
                {
                    middager.Add(matValg.title, nr);
                }
                else
                {
                    middager[matValg.title] += nr;
                }
            }
        }

        static void printPrice(Dictionary<string, int> middager, DinnerData dinnerData, FoodData foodData)
        {
            int totalPris = 0;

            Dictionary<int, double> ingredienser = new Dictionary<int, double>();

            foreach (KeyValuePair<string, int> middag in middager)
            {
                Dinner d = null;
                foreach (Dinner dinner in dinnerData.dinners)
                {
                    if (dinner.title.Equals(middag.Key))
                    {
                        d = dinner;
                        break;
                    }
                }

                if (d == null)
                {
                    throw new Exception("FEIL! Fant ikke middag");
                }
                else
                {
                    foreach (Ingredient i in d.ingredients)
                    {
                        if (!ingredienser.ContainsKey(i.ingredientCode))
                        {
                            ingredienser.Add(i.ingredientCode, i.amountOfItem * middag.Value);
                        }
                        else
                        {
                            ingredienser[i.ingredientCode] += i.amountOfItem * middag.Value;
                        }
                    }
                }
            }

            Console.WriteLine("\nHandleliste:");
            Console.WriteLine("------------\n");
            foreach (KeyValuePair<int, double> ingrediens in ingredienser)
            {
                FoodItem f = foodData.getFood(ingrediens.Key);

                if (f == null)
                {
                    throw new Exception("FEIL! Fant ikke mat " + IngredientUtils.getIngredientDesc(ingrediens.Key));
                }
                else
                {
                    Console.WriteLine(IngredientUtils.getIngredientDesc(ingrediens.Key) + ": " + (int) Math.Ceiling(ingrediens.Value) + " (" + ingrediens.Value + ") * " + f.priceNOK + " kr");
                    totalPris += f.priceNOK * (int) Math.Ceiling(ingrediens.Value);
                }
            }
            Console.WriteLine("\nSUM = " + totalPris + " kr");
        }
    }
}
