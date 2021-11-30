using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RSSUtilities;
using RSSUtilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EjnerHesselRssFeed.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public List<CustomRSSViewModel> RSSViewModels { get; set; }
		public string rsslink { get; set; }

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet(string rsslink)
		{
			
			RSSReader reader;
			if (!String.IsNullOrEmpty(HttpUtility.UrlDecode(rsslink)))
			{
				reader = new RSSReader(HttpUtility.UrlDecode(rsslink));
			}
			else
			{
				reader = new RSSReader();
			}

			RSSViewModels = reader.GetRSSFeed();
		}
	}
}
