using System.ComponentModel.DataAnnotations;

namespace Food_Project.Models
{
	public class Category
	{
        public int CategoryId { get; set; }
     
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set;}

    }
}
