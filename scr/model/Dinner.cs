using System.Collections.Generic;

namespace handleplan
{
    public class Dinner
    {
        public List<Ingredient> ingredients;
        public string title;

        public Dinner(string title, List<Ingredient> ingredients)
        {
            this.title = title;
            this.ingredients = ingredients;
        }
    }
}