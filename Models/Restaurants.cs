using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteRestaurantsCapstone.Models
{
    public class Restaurants
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the name of the restaurant!")]
        [StringLength(50)]
        
        public string RestaurantName { get; set; }
        
        [Required(ErrorMessage = "Please enter the restaurant's street address.")]
        
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Please enter the restaurant's city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the restaurant's Cusine Type")]
        [StringLength(40)]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
       
        public string CuisineType { get; set; }

        [Required(ErrorMessage = "Please enter the average cost of a meal.")]
        [Range(0, 120, ErrorMessage = "Please enter the average cost of the meal between 0 and 150.")]
        [DataType(DataType.Currency)]
        
        public int AverageCost { get; set; }

        [Required(ErrorMessage = "Please enter the best menu items for the restauarant")]
        
        public string MenuItems { get; set; }
    }
}
