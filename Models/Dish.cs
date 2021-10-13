using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicous.Models
{
    public class Dish
    {
        //chefName, DishName, Calories, Description, TasteLvl
        [Key]
        public int DishId {get;set;}
        public string ChefName {get;set;}
        public string DishName {get;set;}
        public int Calories {get;set;}
        public int Taste {get;set;}
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}