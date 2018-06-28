using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrsServer.Models
{
	public class User	{

		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Username { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[StringLength(50)]
		public string Firstname { get; set; }

		[Required]
		[StringLength(50)]
		public string Lastname { get; set; }

		[Required]
		[StringLength(10)]
		public string Phone { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]		
		public bool IsReviewer { get; set; } = false;

		[Required]		
		public bool IsAdmin { get; set; } = false;

		[Required]		
		public bool Active { get; set; } = true;

		public User() { }
	}
}