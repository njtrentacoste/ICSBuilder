using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICSBuilder.Data.Models
{
	public class ICSEvent
	{
		public string UserId { get; set; }
		public DateTime DateStamp { get; set; }
		public ICSOrganizer Organizer { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public string Summary { get; set; }
	}
}