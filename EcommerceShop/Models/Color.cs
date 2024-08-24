using System.ComponentModel.DataAnnotations;

namespace EcommerceShop.Models
{
	public class Color
	{
		[Key]
		public int ColorId { get; set; }
		[Required]
		[StringLength(200)]
		public string? ColorName { get; set; }
	}
}
