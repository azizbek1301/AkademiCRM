using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Notification.Command;

namespace StudyCenter.Service.UseCases.Notification.Handler
{
    public class CreateNotificationHandler : IRequestHandler<CreateNotificationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateNotificationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
        {
            Notifications? notifications = new Notifications()
            {
                MEssage=request.Message,
                Date=DateTime.UtcNow,
                Student_Id=request.Student_Id,
            };
            await _context.Notifications.AddAsync(notifications, cancellationToken);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
