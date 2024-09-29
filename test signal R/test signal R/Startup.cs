using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(test_signal_R.Startup))]

namespace test_signal_R
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Cấu hình CORS
            app.UseCors(CorsOptions.AllowAll);
            // Map SignalR hubs
            app.MapSignalR();

        }
    }
}
