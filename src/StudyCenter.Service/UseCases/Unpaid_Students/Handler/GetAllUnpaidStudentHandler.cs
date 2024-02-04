using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Unpaid_Students.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Handler
{
    public class GetAllUnpaidStudentHandler : IRequestHandler<GetAllUnpaidStudentQuery, List<Unpaid_Student>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllUnpaidStudentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Unpaid_Student>> Handle(GetAllUnpaidStudentQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Unpaid_Students.ToListAsync(cancellationToken);
            return res;
        }
    }
}
