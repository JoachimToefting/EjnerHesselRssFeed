using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using RSSUtilities.Models;

namespace RSSUtilities
{
	//https://khalidabuhakmeh.com/reading-rss-feeds-with-dotnet-core
	//https://www.nuget.org/packages/System.ServiceModel.Syndication/
	public class RSSReader
	{
		string _address = "https://www.dr.dk/nyheder/service/feeds/senestenyt";
		//handle string address
		public RSSReader()
		{

		}
		public RSSReader(string address)
		{
			_address = address;
		}
		public List<CustomRSSViewModel> GetRSSFeed()
		{
			using XmlReader reader = XmlReader.Create(_address);
			SyndicationFeed feed = SyndicationFeed.Load(reader);
			List<CustomRSSViewModel> returnList = new List<CustomRSSViewModel>();
			foreach (var item in feed.Items)
			{
				returnList.Add(new CustomRSSViewModel(item));
			}
			return returnList;
		}
	}
}
