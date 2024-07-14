using Food_Project.Data;
using Food_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Food_Project.Repository
{
	public class GenericRepository<T> where T : class, new()
	{

		private readonly AppDbContext _context;
		public GenericRepository(AppDbContext context)
		{
			_context = context;
		}
		public List<T> ListT()
		{

			return _context.Set<T>().ToList();
		}

		public void AddT(T p)
		{
			_context.Set<T>().Add(p);
			_context.SaveChanges();
		}
		public void DeleteT(T p)
		{
			_context.Set<T>().Remove(p);
			_context.SaveChanges();
		}
		public void UpdateT(T p)
		{
			_context.Set<T>().Update(p);
			_context.SaveChanges();
		}
		public T GetT(int id)
		{
			return _context.Set<T>().Find(id);

		}
		public List<T> TList(string p)
		{
			var item= _context.Set<T>().Include(p).ToList();
			return item;
		}
	}
}
