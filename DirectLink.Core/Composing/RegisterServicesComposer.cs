using DirectLink.Core.Services;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace DirectLink.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
            composition.Register<IGameService, GameService>(Lifetime.Request);
        }
    }
}
