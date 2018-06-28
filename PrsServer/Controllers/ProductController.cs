using PrsServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrsServer.Controllers
{
    public class ProductController : ApiController    {

		private PrsServerDbContext db = new PrsServerDbContext();

		[HttpGet]
		[ActionName("List")]
		public IEnumerable<Product> List()
		{
			return db.Products.ToList();

		}
		[HttpGet]
		[ActionName("Get")]
		public Product Get(int? id)
		{
			if (id == null)
				return null;
			return db.Products.Find(id);
		}
		[HttpPost]
		[ActionName("Create")]
		public bool Create(Product product)
		{
			if (product == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			db.Products.Add(product);
			db.SaveChanges();
			return true;
		}
		[HttpPost]
		[ActionName("Change")]
		public bool Change(Product product)
		{
			if (product == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			var prod = db.Products.Find(product.Id);
			prod.Partnumber = product.Partnumber;
			prod.Name = product.Name;
			prod.Price = product.Price;
			prod.Unit = product.Unit;
			prod.Photopath = product.Photopath;
			prod.VendorId = product.VendorId;
			db.SaveChanges();
			return true;
		}
		[HttpPost]
		[ActionName("Remove")]
		public bool Remove(Product product)
		{
			if (product == null)
				return false;
			if (!ModelState.IsValid) {
				return false;
			}
			var prod = db.Products.Find(product.Id);
			db.Products.Remove(prod);
			db.SaveChanges();
			return true;
		}
	}
}
