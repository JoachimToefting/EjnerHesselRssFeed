using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;

namespace RSSUtilities.Models
{
	public class CustomRSSViewModel
	{
		public CustomRSSViewModel(SyndicationItem item)
		{
			//Kunne have brugt extension istedet/mapper
			Title = item.Title.Text;
			PublicationTime = item.PublishDate.DateTime;
			ArticleLink = item.Links.FirstOrDefault().Uri;
		}
		public string Title { get; set; }
		public DateTime PublicationTime { get; set; }
		public Uri ArticleLink { get; set; }
	}
}
