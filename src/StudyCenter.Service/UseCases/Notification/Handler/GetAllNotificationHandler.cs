using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Notification.Queries;
using System.Reflection.Metadata;

namespace StudyCenter.Service.UseCases.Notification.Handler
{
    public class GetAllNotificationHandler : IRequestHandler<GetAllNotificationQuery, List<Notifications>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllNotificationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notifications>> Handle(GetAllNotificationQuery request, CancellationToken cancellationToken)
        {
            List<Notifications> documents = await _context.Notifications.ToListAsync(cancellationToken);

            if (documents.Count() == 0)
                throw new Exception("Not Found"); ;
            return documents;
        }
    }
}
