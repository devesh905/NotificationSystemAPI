using Microsoft.AspNetCore.Mvc;
using Notification_System_API.Services;
using Notification_System_API.DTOs;

namespace Notification_System_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {

        // This is a private field that holds a reference(Reference variable) to the INotificationService instance. It is used to send notifications.
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send")]
        public IActionResult SendNotification(NotificationRequest request)
        {
            _notificationService.Send(request.Message);
            return Ok();
        }

    }
}
