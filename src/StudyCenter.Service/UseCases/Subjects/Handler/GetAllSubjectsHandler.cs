using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Subjects.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Subjects.Handler
{
    public class GetAllSubjectsHandler : IRequestHandler<GetAllSubjectsQuery, List<Subject>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllSubjectsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> Handle(GetAllSubjectsQuery request, CancellationToken cancellationToken)
        {
            var subject=await _context.Subjects.ToListAsync(cancellationToken);
            return subject;
        }
    }
}
