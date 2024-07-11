using Food_Project.Data;
using Food_Project.Models;

namespace Food_Project.Repository
{
	public class FoodRepository : GenericRepository<Food>
	{
		public FoodRepository(AppDbContext context) : base(context)
		{
		}
	}
}
