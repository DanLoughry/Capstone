﻿using PrsServer.Models;
using PrsServer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PrsServer.Controllers{

	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class VendorController : ApiController
	{

		private PrsServerDbContext db = new PrsServerDbContext();

		[HttpGet]
		[ActionName("List")]
		public JSONResponse List()
		{
			return new JSONResponse {
				Data = db.Vendors.ToList()
			};
		}

		[HttpGet]
		[ActionName("Get")]
		public JSONResponse Get(int? id)
		{
			if (id == null) {
				return new JSONResponse {
					Result = "failed",
					Message = "ID does not exist"
				};
			}
			return new JSONResponse {
				Data = db.Vendors.Find(id)
			};
		}

		[HttpPost]
		[ActionName("Create")]
		public JSONResponse Create(Vendor vendor)
		{
			if (vendor == null) {
				return new JSONResponse {
					Result = "failed",
					Message = "Failed to create becasue null"
				};
			}
			if (!ModelState.IsValid) {
				return new JSONResponse {
					Result = "failed",
					Message = "Model state is invalid, see error",
					Error = ModelState
				};
			}
			db.Vendors.Add(vendor);
			db.SaveChanges();
			return new JSONResponse {
				Message = "Success",
				Data = vendor
			};
		}

		[HttpPost]
		[ActionName("Change")]
		public JSONResponse Change(Vendor vendor)
		{
			if (vendor == null) {
				return new JSONResponse {
					Result = "failed",
					Message = "Failed to create because null"
				};
			}
			if (!ModelState.IsValid) {
				return new JSONResponse {
					Result = "failed",
					Message = "Modelstate invalid, see error",
					Error = ModelState
				};
			}
			db.Entry(vendor).State = System.Data.Entity.EntityState.Modified;
			db.SaveChanges();
			return new JSONResponse {
				Message = "Success",
				Data = vendor
			};
		}

		[HttpPost]
		[ActionName("Remove")]
		public JSONResponse Remove(Vendor vendor)
		{
			if (vendor == null) {
				return new JSONResponse {
					Result = "failed",
					Message = "Failed to remove because null"
				};
			}
			if (!ModelState.IsValid) {
				return new JSONResponse {
					Result = "failed",
					Message = "Modelstate invalid, see error",
					Error = ModelState
				};
			}
			db.Entry(vendor).State = System.Data.Entity.EntityState.Deleted;
			db.SaveChanges();
			return new JSONResponse {
				Message = "Success",
				Data = vendor
			};
		}
	}
}
