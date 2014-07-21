using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCustomerDatabase.Web.Startup))]
namespace SimpleCustomerDatabase.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
