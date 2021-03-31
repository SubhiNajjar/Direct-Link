using DirectLink.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace DirectLink.Core.Services
{
    public interface IGameService
    {
        IPublishedContent GetGameListPage(IPublishedContent siteRoot);
        IEnumerable<IPublishedContent> GetLatestGames(IPublishedContent siteRoot);
        GameResultSet GetLatestGames(IPublishedContent currentContentItem, HttpRequestBase request);
    }
}
