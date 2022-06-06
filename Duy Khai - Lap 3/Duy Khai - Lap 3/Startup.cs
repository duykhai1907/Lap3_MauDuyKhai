using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Duy_Khai___Lap_3.Startup))]
namespace Duy_Khai___Lap_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
