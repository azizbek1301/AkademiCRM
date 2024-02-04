using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Notification.Queries
{
    public class GetAllNotificationQuery:IRequest<List<Notifications>>
    {
    }
}
