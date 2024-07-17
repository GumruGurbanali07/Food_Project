using System.ComponentModel.DataAnnotations;

namespace Food_Project.Models
{
	public class Admin
	{
		[Key]
		 public int AdminID { get; set; }
		public string Username {  get; set; }
		[StringLength(8)]
		public string Password { get; set; }
		[StringLength (1)]
		public string AdminRole {  get; set; }
	}
}
