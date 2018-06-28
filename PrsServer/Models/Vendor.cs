using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsServer.Models
{
	public class Vendor
	{

		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Code { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(80)]
		public string Address { get; set; }

		[Required]
		[StringLength(50)]
		public string City { get; set; }

		[Required]
		[StringLength(2)]
		public string State { get; set; }

		[Required]
		[StringLength(5)]
		public string Zip { get; set; }

		[Required]
		[StringLength(50)]
		public string Phone { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Email { get; set; }

		[Required]		
		public bool IsApproved { get; set; }

		[Required]
		public bool Active { get; set; }

		public Vendor() { }
	}
}