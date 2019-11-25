namespace handleplan
{
    public class FoodItem
    {
        public int priceNOK;
        public int ingredientCode;

        public FoodItem(int code, int nok)
        {
            this.priceNOK = nok;
            this.ingredientCode = code;
        }
    }
}