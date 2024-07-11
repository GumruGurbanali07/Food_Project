using Food_Project.Data;
using Food_Project.Models;
using System.Collections.Generic;
using System.Linq;
namespace Food_Project.Repository
{
	public class CategoryRepository : GenericRepository<Category>
	{
		public CategoryRepository(AppDbContext context) : base(context)
		{
		}
	}
}
