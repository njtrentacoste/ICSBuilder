using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICSBuilder.Models
{
	public class Event
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string StartDate { get; set; }
		public string StartTime { get; set; }
		public string EndDate { get; set; }
		public string EndTime { get; set; }
		public TimeSpan Reminder { get; set; }
		public string Location { get; set; }
		public bool IsRecurring { get; set; }
		public RecurringFrequency ReoccurFrequency { get; set; }
	}
}