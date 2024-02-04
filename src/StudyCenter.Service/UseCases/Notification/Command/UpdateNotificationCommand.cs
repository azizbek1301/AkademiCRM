using MediatR;
using StudyCenter.Domain.Dtos.Notifications;

namespace StudyCenter.Service.UseCases.Notification.Command
{
    public class UpdateNotificationCommand:NotificationUpdateDto,IRequest<int>
    {
    }
}
