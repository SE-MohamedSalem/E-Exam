using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EExam.Startup))]
namespace EExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
