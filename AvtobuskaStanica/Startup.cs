using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AvtobuskaStanica.Startup))]
namespace AvtobuskaStanica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
