using DirectLink.Core.Services;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Services;
using Umbraco.Web.Mvc;
using Current = Umbraco.Web.Composing.Current;

namespace DirectLink.Core.ViewPages
{
    public abstract class DirectLinkViewPage<T> : UmbracoViewPage<T>
    {
        private readonly IGameService GameService;

        public DirectLinkViewPage() : this(
           Current.Factory.GetInstance<IGameService>(),
           Current.Factory.GetInstance<ServiceContext>(),
           Current.Factory.GetInstance<AppCaches>()
       )
        { }

        public DirectLinkViewPage(IGameService gameService, ServiceContext services, AppCaches appCaches)
        {
            GameService = gameService;
            Services = services;
            AppCaches = appCaches;
        }

    }
    public abstract class DirectLinkViewPage : UmbracoViewPage
    {
        public readonly IGameService GameService;
        public DirectLinkViewPage() : this(
            Current.Factory.GetInstance<IGameService>(),
            Current.Factory.GetInstance<ServiceContext>(),
            Current.Factory.GetInstance<AppCaches>()
        )
        { }

        public DirectLinkViewPage(IGameService gameService, ServiceContext services, AppCaches appCaches)
        {
            GameService = gameService;
            Services = services;
            AppCaches = appCaches;
        }
    }
}
