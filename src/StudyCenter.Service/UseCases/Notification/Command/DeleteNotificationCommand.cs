using MediatR;

namespace StudyCenter.Service.UseCases.Notification.Command
{
    public class DeleteNotificationCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
