using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Notification.Queries
{
    public class GetNotificationByIdQuery:IRequest<Notifications>
    {
        public int Id { get; set; } 
    }
}
