using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace panini.Models
{
    public class Sandwich
    {
        [Key]
        public int IdNumber { get; set; }

        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only letters and spaces are accepted")]
        [MaxLength(50, ErrorMessage = "Characters exceed the limit of 50")]
        [Display (Name = "Name")]
        public string Name { get; set; }

        [Required (ErrorMessage="Sandwich can't be free")]
        [RegularExpression(@"^[0.1-9]\d{0,2}$", ErrorMessage = "Only numbers between 0.1-999 are accepted")]
        [Display(Name = "Cost")]
        public double Cost { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are accepted")]
        [MaxLength(50, ErrorMessage = "Characters exceed the limit of 50")]
        [Display(Name = "Cuisine")]
        public string Cuisine { get; set; }

        public IngredientsList Ingredients { get; set; }

        public enum IngredientsList {
            Tomato,
            Lettuce,
            Egg,
            Cheese,
            Bacon,
            Mayonnaise
        }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Photo URL")]
        public string PhotoUrl { get; set; }

        [Required]
        [Display(Name = "Toasted or not?")]
        public bool IsToasted { get; set; }
    }
}