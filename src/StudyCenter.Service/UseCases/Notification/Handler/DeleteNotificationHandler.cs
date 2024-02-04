using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Notification.Command;

namespace StudyCenter.Service.UseCases.Notification.Handler
{
    public class DeleteNotificationHandler : IRequestHandler<DeleteNotificationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteNotificationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
        {
            Notifications? notifications = await _context.Notifications.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (notifications == null)
            {
                throw new Exception("Not Found");
            }
            _context.Notifications.Remove(notifications);
            int response = await _context.SaveChangesAsync(cancellationToken);

            return response;
        }
    }
}
