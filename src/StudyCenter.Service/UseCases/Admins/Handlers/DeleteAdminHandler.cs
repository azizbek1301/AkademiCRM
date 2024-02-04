using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Admins.Commands;

namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class DeleteAdminHandler : IRequestHandler<DeleteAdminCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteAdminCommand request, CancellationToken cancellationToken)
        {
            Admin? admin = await _context.Admins.FirstOrDefaultAsync(x => x.AdminId == request.AdminId, cancellationToken);
            _context.Admins.Remove(admin);
            int response = await _context.SaveChangesAsync(cancellationToken);
            return response;
        }
    }
}
