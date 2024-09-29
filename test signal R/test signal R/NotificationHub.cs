using Microsoft.AspNet.SignalR;

public class NotificationHub : Hub
{
    // Phương thức này sẽ được gọi từ server để gửi thông báo tới tất cả các client
    public void SendNotification(string message)
    {
        // Gửi thông báo tới tất cả các client đã kết nối
        Clients.All.receiveNotification(message);
    }
}
