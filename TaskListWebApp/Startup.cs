using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskListWebApp.Startup))]
namespace TaskListWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
