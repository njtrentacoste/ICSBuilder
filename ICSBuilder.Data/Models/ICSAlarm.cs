using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICSBuilder.Data.Models
{
	public class ICSAlarm
	{
		public VAlarmAction Action { get; set; }
		public string Description { get; set; }
		public VAlarmTrigger Trigger { get; set; }
	}
}