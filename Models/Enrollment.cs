using System;

namespace DisplayProp.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid MealID { get; set; }
        public Grade? Grade { get; set; }

        public Meal Meal { get; set; }
        public Camper Camper { get; set; }
    }
}