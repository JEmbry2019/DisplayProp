using System;

namespace DisplayProp.Models
{
    public enum Food
    {
        Meat, Veg, Snack
    }

     public enum Morn
    {
        Cereal, Eggs, Sausage
    }

        public enum Mid
    {
        Hamburger, Hotdog, Salad
    }
    public class Meal
    {
        public Guid ID { get; set; }
       
        public Morn Breakfast { get; set; }
        public Mid Lunch { get; set; }
        public Food Type { get; set;}

    }
}