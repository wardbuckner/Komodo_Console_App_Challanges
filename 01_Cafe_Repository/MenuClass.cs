using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_Repository
{
    public class MenuClass
    {
        // From video Building the repository
        // From Streaming Content POCO
        // Constructors
        public MenuClass() { }
        public MenuClass(int MealNumber, string MealName, string Description, List<string> ListOfIngredients, decimal Price)

        {
            MealNumber = mealNumber;
            MealName = mealName
            Description = description;
            ListOfIngredients = listOfIngredients;
            Price = price;
        }

        // Get Sets

        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public List<string> ListOfIngredients { get; set; }
        public decimal Price { get; set; }

    }
}
