using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SensitiveData.Startup))]
namespace SensitiveData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
