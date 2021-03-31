using DirectLink.Core.Helpers;
using DirectLink.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace DirectLink.Core.Services
{
    public class GameService : IGameService
    {
        public IPublishedContent GetGameListPage(IPublishedContent siteRoot)
        {
            return siteRoot.Descendants().FirstOrDefault(x => x.ContentType.Alias == "gameList");
        }

        public IEnumerable<IPublishedContent> GetLatestGames(IPublishedContent siteRoot)
        {
            var gameList = GetGameListPage(siteRoot);
            var games = gameList.Descendants().Where(x => x.ContentType.Alias == "game" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>("gameDate"));
            return games;
        }

        public GameResultSet GetLatestGames(IPublishedContent currentContentItem, HttpRequestBase request)
        {
            var siteRoot = currentContentItem.Root();
            var gameList = GetGameListPage(siteRoot);
            var games = gameList.Descendants().Where(x => x.ContentType.Alias == "game" && x.IsVisible()).OrderByDescending(y => y.Value<DateTime>("gameDate"));

            var isGameListPage = gameList.Id == currentContentItem.Id;
            var fallbackPageSize = isGameListPage ? 9 : 3;

            var pageNumber = QueryStringHelper.GetIntFromQueryString(request, "page", 1);
            var pageSize = QueryStringHelper.GetIntFromQueryString(request, "size", fallbackPageSize);

            var pageOfGames = games.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var totalItemCount = games.Count();
            var pageCount = totalItemCount > 0 ? Math.Ceiling((double)totalItemCount / pageSize) : 1;

            var resultSet = new GameResultSet()
            {
                PageCount = pageCount,
                PageSize = pageSize,
                PageNumber = pageNumber,
                IsGameListPage = isGameListPage,
                Results = pageOfGames,
                Url = gameList.Url
            };
            return resultSet;
        }
    }
}
