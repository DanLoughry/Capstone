using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsServer.Models
{
	public class Product	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Partnumber { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal Price { get; set; }

		[Required]
		[StringLength(50)]
		public string Unit { get; set; }

		[Required]
		[StringLength(50)]
		public string Photopath { get; set; }

		[Required]
		[Range(0,9)]
		public int VendorId { get; set; }

		public virtual Vendor Vendor { get; set; }

		public Product() { }
	}
}