

using Microsoft.AspNet.SignalR;
using System.Web.Http;

namespace test_signal_R.Controllers
{
	public class HomeController : ApiController
	{
        [HttpGet]
		public IHttpActionResult Index()
		{
            // Nhận context của SignalR
            var context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();

            // Gọi phương thức SendNotification để gửi thông báo tới tất cả client
            context.Clients.All.receiveNotification("Đã vào hub");

            return Ok("Notification sent to all clients.");
        }
	}
}
