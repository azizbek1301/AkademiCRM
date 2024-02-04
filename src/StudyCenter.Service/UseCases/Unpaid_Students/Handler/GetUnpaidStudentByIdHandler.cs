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
    public class GetUnpaidStudentByIdHandler : IRequestHandler<GetUnpaidStudentByIdQuery, Unpaid_Student>
    {
        private readonly IApplicationDbContext _context;

        public GetUnpaidStudentByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unpaid_Student> Handle(GetUnpaidStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var res =await _context.Unpaid_Students.FirstOrDefaultAsync(x=>x.Id == request.Id,cancellationToken);
            if (res == null)
            {
                throw new Exception("Not Found");

            }
            return res;
        }
    }
}
