using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mongo.Startup))]
namespace Mongo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
