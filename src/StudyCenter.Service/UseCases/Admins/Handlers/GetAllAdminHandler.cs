using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Admins.Queries;

namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class GetAllAdminHandler : IRequestHandler<GetAllAdminQuery, List<Admin>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        async Task<List<Admin>> IRequestHandler<GetAllAdminQuery, List<Admin>>.Handle(GetAllAdminQuery request, CancellationToken cancellationToken)
        {
            var admins = await _context.Admins.ToListAsync(cancellationToken);
            return admins;
        }
    }
}
