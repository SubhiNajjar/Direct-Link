using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace DirectLink.Core.ViewModels
{
    public class GameResultSet
    {
        public IEnumerable<IPublishedContent> Results { get;set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public double PageCount { get; set; }
        public bool IsGameListPage { get; set; }
        public string Url { get; set; }
    }
}
