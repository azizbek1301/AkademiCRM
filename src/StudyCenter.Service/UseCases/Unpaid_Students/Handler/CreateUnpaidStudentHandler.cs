using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Unpaid_Students.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Handler
{
    public class CreateUnpaidStudentHandler : IRequestHandler<CreateUnpaidStudentCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateUnpaidStudentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUnpaidStudentCommand request, CancellationToken cancellationToken)
        {
            var unpaid = new Unpaid_Student()
            {
                StudentId = request.StudentId,
                Price = request.Price,
            };
            await _context.Unpaid_Students.AddAsync(unpaid);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
