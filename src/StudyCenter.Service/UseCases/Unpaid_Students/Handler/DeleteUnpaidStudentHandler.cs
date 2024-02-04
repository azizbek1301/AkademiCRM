using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Unpaid_Students.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Handler
{
    public class DeleteUnpaidStudentHandler : IRequestHandler<DeleteunpaidStudentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteUnpaidStudentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteunpaidStudentCommand request, CancellationToken cancellationToken)
        {
            var res = await _context.Unpaid_Students.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (res == null)
            {
                throw new Exception("Not Found");

            }
            _context.Unpaid_Students.Remove(res);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
