﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrsServer.Models
{
	public class PrsServerDbContext : DbContext	{

		public PrsServerDbContext() : base() { }
		public DbSet<User> Users { get; set; }
		public DbSet<Vendor> Vendors { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
		public DbSet<PurchaseRequestLineItem> PurchaseRequestLineItems { get; set; }
	}
}