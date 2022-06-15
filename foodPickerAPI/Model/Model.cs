using System;
using System.Collections.Generic;
using System.Text;

namespace foodPicker.Model
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string IngredientNaam { get; set; }

    }
    public class DB_Recept
    {
        public int Id { get; set; }
        public string ReceptNaam { get; set; }
        public int[] BenodigdeIngredienten { get; set; }
    }

    public class Recept
    {
        public int Id { get; set; }
        public string ReceptNaam { get; set; }
        public List <Ingredient> BenodigdeIngredienten { get; set; }
    }

    public class Database
    {
        public Ingredient[] Ingredienten { get; set; }
        public DB_Recept[] Recepten { get; set; }
    }

/*    public class FitbitDB
    {
        public FitbitDataEntry[] BolongoBased { get; set; }
    }*/

    public class FitbitDataEntry
    {
        public DateTime Date { get; set; }
        public int DurationInSeconds { get; set; }
    }
}
