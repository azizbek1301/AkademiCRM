using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teachers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Teachers.Handler
{
    public class GetAllTeacherHandler : IRequestHandler<GetAllTeacherQuery, List<Teacher>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTeacherHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Teacher>> Handle(GetAllTeacherQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.Teachers.ToListAsync(cancellationToken);
            return res;
        }
    }
}
