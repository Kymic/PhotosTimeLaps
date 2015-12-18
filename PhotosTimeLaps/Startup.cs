using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotosTimeLaps.Startup))]
namespace PhotosTimeLaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
