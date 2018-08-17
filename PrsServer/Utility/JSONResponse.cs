using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrsServer.Utility
{
	public class JSONResponse {

		public static JSONResponse ok = new JSONResponse();

		public int Code { get; set; } = 0;
		public string Result { get; set; } = "ok";
		public string Message { get; set; } = "success";
		public object Data { get; set; } 
		public object Error { get; set; }

		public JSONResponse() { }


	}
}