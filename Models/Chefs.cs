using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CRUDelicous.Models
{
    public class Chef
    {
        
        [Key]
        public int ChefId {get;set;}

        [Required(ErrorMessage="Your Chef Must have a First Name!")]
        public string ChefFirstName {get;set;}

        [Required(ErrorMessage="Your Chef Must have a Last Name!")]
        public string ChefLastName {get;set;}


        [Required(ErrorMessage="Your Chef Must been Born or hatched or something!! Please Enter a Date")]
        [DataType(DataType.Date)]
        public DateTime Birthday {get;set;} 

        public List<Dish> Dishes {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}