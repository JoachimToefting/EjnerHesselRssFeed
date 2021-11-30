using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjnerHesselRssFeed.Pages
{
	public class InputModel : PageModel
	{
		[BindProperty]
		public string RSSInputField { get; set; }
		public string rsslink;
		public void OnGet()
		{
		}
		[HttpPost]
		public ActionResult OnPost()
		{
			return RedirectToPage("Index", new { rsslink = RSSInputField});
		}
	}
}
