using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.Security;
using StudyCenter.Service.UseCases.Admins.Commands;


namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class CreateAdminHandler : IRequestHandler<CreateAdminCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            Admin checkAdmin = await _context.Admins.FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);

            Admin admin = new Admin()
            {
                Email = request.Email,
                FullName = request.FullName,
                PasswordHash = PasswordHash.ComputeShA512HashFromString(request.Password),
                Role = request.Role

            };
            await _context.Admins.AddAsync(admin);
            int response = await _context.SaveChangesAsync(cancellationToken);


            return response;

        }
    }
}
