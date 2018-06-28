using PrsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrsServer.Controllers
{
	public class UserController : ApiController
	{

		private PrsServerDbContext db = new PrsServerDbContext();

		[HttpGet]
		[ActionName("List")]
		public IEnumerable<User> List()
		{
			return db.Users.ToList();

		}
		[HttpGet]
		[ActionName("Get")]
		public User Get(int? id)
		{
			if (id == null)
				return null;
			return db.Users.Find(id);
		}
		[HttpPost]
		[ActionName("Create")]
		public bool Create(User user)
		{
			if (user == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			db.Users.Add(user);
			db.SaveChanges();
			return true;
		}
		[HttpPost]
		[ActionName("Change")]
		public bool Change(User user)
		{
			if (user == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			var use = db.Users.Find(user.Id);
			use.Username = user.Username;
			use.Password = user.Password;
			use.Firstname = user.Firstname;
			use.Lastname = user.Lastname;
			use.Phone = user.Phone;
			use.Email = user.Email;
			use.IsReviewer = user.IsReviewer;
			use.IsAdmin = user.IsAdmin;
			use.Active = user.Active;
			db.SaveChanges();
			return true;
		}
		[HttpPost]
		[ActionName("Remove")]
		public bool Remove(User user)
		{
			if (user == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			var cust = db.Users.Find(user.Id);
			db.Users.Remove(cust);
			db.SaveChanges();
			return true;
		}
	}
}
