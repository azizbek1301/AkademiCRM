using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.Security;
using StudyCenter.Service.UseCases.Admins.Commands;

namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class UpdateAdminHandler : IRequestHandler<UpdateAdminCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateAdminCommand request, CancellationToken cancellationToken)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(x => x.AdminId == request.AdminId, cancellationToken);


            if (admin != null)
            {
                admin.FullName = request.FullName;
                admin.PasswordHash = PasswordHash.ComputeShA512HashFromString(request.Password);
                admin.Role = request.Role;
                admin.Email = request.Email;
            }

            _context.Admins.Update(admin);
            int respons = await _context.SaveChangesAsync(cancellationToken);
            return respons;


        }
    }
}
