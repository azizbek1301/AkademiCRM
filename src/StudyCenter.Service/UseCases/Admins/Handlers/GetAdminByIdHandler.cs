using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Admins.Queries;

namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class GetAdminByIdHandler : IRequestHandler<GetAdminByIdQuery, Admin>
    {
        private readonly IApplicationDbContext _context;

        public GetAdminByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Admin> Handle(GetAdminByIdQuery request, CancellationToken cancellationToken)
        {
            Admin admin = await _context.Admins.FirstOrDefaultAsync(x => x.AdminId == request.AdminId, cancellationToken);
            return admin;
        }
    }
}
