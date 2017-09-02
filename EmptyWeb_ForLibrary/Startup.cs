using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmptyWeb_ForLibrary.Startup))]
namespace EmptyWeb_ForLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
