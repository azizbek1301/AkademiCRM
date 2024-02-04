using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Notification.Queries;

namespace StudyCenter.Service.UseCases.Notification.Handler
{
    public class GetNotificationByIdHandler : IRequestHandler<GetNotificationByIdQuery, Notifications>
    {
        private readonly IApplicationDbContext _context;

        public GetNotificationByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Notifications> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
        {
            Notifications? notifications=await _context.Notifications.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if(notifications == null)
            {
                throw new Exception("not Found");
            }

            return notifications;
        }
    }
}
