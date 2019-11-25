using System;

namespace handleplan
{
    public enum Ingredients
    {
        Kjøttdeig,
        Kyllingfillet,
        Wienerpølser,
        Vossakorv,
        Middagspølse,
        Grillpølse,
        Servelat,
        Kjøttboller,
        Bacon,
        Koteletter,

        Falafel,
        TacoLefse,

        Egg6pk,
        Ost,
        Melk,
        Fløte,
        Rømme,

        Rundstykke6pk,
        SalamiPakke,
        RekeSalat,
        Kaffe,

        TagliatellePakke, 
        Makaroni,
        Spaghetti,

        RisPose,
        
        Mel,
        LasagnePakke,
        Salsa,
        Gjær,
        HakketTomat,
        SausPakke,
        NachoChips,

        Pølsebrød,

        Løk4pk,
        Gullerot,
        Selleri,
        PotetKg,
        Kolrabi,
        Salat,
        Paprika,
        Tomater,
        Mais3pk,
        Ananas3pk,
        ErterPk,
        Hvitløk,
        Vårløk,
        Brokkoli,

    }

    public class IngredientUtils
    {
        public static string getIngredientDesc(int ingredientCode)
        {
            return Enum.GetName(typeof(Ingredients), ingredientCode);
        }
    }
}