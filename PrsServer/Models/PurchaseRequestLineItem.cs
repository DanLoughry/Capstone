using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsServer.Models
{
	public class PurchaseRequestLineItem	{

		public int Id { get; set; }
		public int Quantity { get; set; }
		public int PurchaseRequestId { get; set; }
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		[JsonIgnore]
		public virtual PurchaseRequest PurchaseRequest { get; set; }

		public PurchaseRequestLineItem() { }
	}
}