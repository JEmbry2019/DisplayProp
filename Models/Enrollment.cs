using System;

namespace DisplayProp.Models
{
    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid GameID { get; set; }
        public Guid CamperID { get; set; }

        public Guid MealID { get; set; }
        

        public Game Game { get; set; }
        public Camper Camper { get; set; }
        public Meal Meal { get; set; }
    }
}