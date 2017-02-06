using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLabbarnas.Startup))]
namespace MVCLabbarnas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
