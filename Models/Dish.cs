using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicous.Models
{
    public class Dish
    {
        //chefName, DishName, Calories, Description, TasteLvl
        [Key]
        public int DishId {get;set;}

        [Required]
        public string DishName {get;set;}

        [Required]
        public int Calories {get;set;}

        [Required]
        public int Taste {get;set;}

        [Required]
        public string Description {get;set;}

        public int ChefId {get;set;}

        [Required]
        public Chef Chef {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}