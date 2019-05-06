using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab08_Lab.Startup))]
namespace Lab08_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
