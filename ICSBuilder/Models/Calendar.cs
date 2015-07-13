using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICSBuilder.Models
{
	public class Calendar
	{
		public string Name { get; set; }
		public List<Event> Events { get; set; }
	}
}