using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Unpaid_Students.Command;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Handler
{
    public class UpdateUnpaidStudentHandler : IRequestHandler<UpdateUnpaidStudentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateUnpaidStudentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateUnpaidStudentCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Unpaid_Students.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            res.StudentId = request.StudentId;
            res.Price = request.Price;

            _context.Unpaid_Students.Update(res);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
