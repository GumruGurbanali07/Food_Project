using System.ComponentModel.DataAnnotations;

namespace Food_Project.DTOs
{
    public class AddFoodDto
    {
        [Required(ErrorMessage ="Food name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Food description is required!")]
        public string LongDescription { get; set; }
       

        [Required(ErrorMessage = "Food price is required!")]
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Food stock is required!")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Category is required!")]
        public int CategoryId { get; set; } 
    }
}
