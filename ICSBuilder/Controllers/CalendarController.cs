using ICSBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICSBuilder.Controllers
{
    public class CalendarController : Controller
    {
		Calendar calendar;
		
        // GET: Calendar
        public ActionResult Index()
        {
			if (Session["calendar"] == null)
			{
				calendar = new Calendar();
				calendar.Events = new List<Event>();
				Session["calendar"] = calendar;
			}
			else
			{
				calendar = (Calendar)Session["calendar"];
			}

            return View(calendar);
        }

		public ActionResult AddEvent()
		{
			var newEvent = new Event();

			return View(newEvent);
		}

		[HttpPost]
		public ActionResult AddEvent(Event model) {
			if (ModelState.IsValid)
			{
				if (model != null)
				{
					if (Session["events"] != null)
					{
						calendar = (Calendar)Session["calendar"];
					}
					else
					{
						calendar = new Calendar();
						calendar.Events = new List<Event>();
					}

					calendar.Events.Add(model);
				}
			}

			return RedirectToAction("Index");
		}
    }
}