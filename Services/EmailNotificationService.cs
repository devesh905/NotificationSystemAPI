namespace Notification_System_API.Services
{
    public class EmailNotificationService : INotificationService
    {

        public void Send(string message)
        {
  
            Console.WriteLine($"Email sent: {message}");

        }

    }
}
