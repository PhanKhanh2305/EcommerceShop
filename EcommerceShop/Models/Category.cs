using System.ComponentModel.DataAnnotations;

namespace EcommerceShop.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		[Required]
		[StringLength(200)]
		public string? CategoryName { get; set; }
		[Required]
		[StringLength(200)]
		public string? CategoryPhoto { get; set; }
		public int CategoryOrder { get; set; }
	}
}
