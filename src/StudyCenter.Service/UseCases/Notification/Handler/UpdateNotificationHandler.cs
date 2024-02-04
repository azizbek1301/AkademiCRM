using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Notification.Command;

namespace StudyCenter.Service.UseCases.Notification.Handler
{
    public class UpdateNotificationHandler : IRequestHandler<UpdateNotificationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateNotificationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
        {
            Notifications? notifications=await _context.Notifications.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (notifications==null)
            {
                throw new Exception("Not Found");
            }
            notifications.MEssage = request.Message;
            notifications.Date = DateTime.UtcNow;
          

            _context.Notifications.Update(notifications);
            return await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
