namespace Food_Project.Models
{
	public class Food
	{
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbNailImageUrl { get; set; }
        public int Stock { get; set; }

        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    }
}
