using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimeDevenge.Startup))]
namespace PrimeDevenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
