using System.Collections.Generic;

namespace handleplan
{
    public class FoodData
    {
        List<FoodItem> foods;

        public FoodData()
        {
            foods = new List<FoodItem>
            {
                new FoodItem((int) Ingredients.Kjøttdeig, 40),
                new FoodItem((int) Ingredients.PotetKg, 20),
                new FoodItem((int) Ingredients.Løk4pk, 20),
                new FoodItem((int) Ingredients.Melk, 20),
                new FoodItem((int) Ingredients.Servelat, 50),
                new FoodItem((int) Ingredients.Egg6pk, 20),
                new FoodItem((int) Ingredients.Hvitløk, 20),
                new FoodItem((int) Ingredients.Vårløk, 25),
                new FoodItem((int) Ingredients.HakketTomat, 10),
                new FoodItem((int) Ingredients.LasagnePakke, 40),
                new FoodItem((int) Ingredients.Fløte, 20),
                new FoodItem((int) Ingredients.Falafel, 40),
                new FoodItem((int) Ingredients.TacoLefse, 25),
                new FoodItem((int) Ingredients.Rømme, 20),
                new FoodItem((int) Ingredients.Paprika, 8),
                new FoodItem((int) Ingredients.Mais3pk, 15),
                new FoodItem((int) Ingredients.Ananas3pk, 20),
                new FoodItem((int) Ingredients.Ost, 110),
                new FoodItem((int) Ingredients.Salat, 15),
                new FoodItem((int) Ingredients.Salsa, 25),
                new FoodItem((int) Ingredients.Bacon, 25),
                new FoodItem((int) Ingredients.Mel, 15),
                new FoodItem((int) Ingredients.Gjær, 25),
                new FoodItem((int) Ingredients.TagliatellePakke, 30),
                new FoodItem((int) Ingredients.ErterPk, 20),
                new FoodItem((int) Ingredients.Tomater, 20),
                new FoodItem((int) Ingredients.Wienerpølser, 40),
                new FoodItem((int) Ingredients.Pølsebrød, 25),
                new FoodItem((int) Ingredients.SausPakke, 15),
                new FoodItem((int) Ingredients.Kjøttboller, 80),
                new FoodItem((int) Ingredients.Rundstykke6pk, 35),
                new FoodItem((int) Ingredients.RekeSalat, 20),
                new FoodItem((int) Ingredients.Kaffe, 140),
                new FoodItem((int) Ingredients.SalamiPakke, 30),
                new FoodItem((int) Ingredients.NachoChips, 30),
                new FoodItem((int) Ingredients.Vossakorv, 35),
            };
        }

        public FoodItem getFood(int code)
        {
            foreach (FoodItem item in foods)
            {
                if (item.ingredientCode == code)
                {
                    return item;
                }
            }
            return null;
        }
    }
}