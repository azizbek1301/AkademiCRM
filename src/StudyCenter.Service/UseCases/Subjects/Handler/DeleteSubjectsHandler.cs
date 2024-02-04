using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Subjects.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCenter.Service.UseCases.Subjects.Handler
{
    public class DeleteSubjectsHandler : IRequestHandler<DeleteSubjectsCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public DeleteSubjectsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteSubjectsCommand request, CancellationToken cancellationToken)
        {
            var subject=await _context.Subjects.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken);
            if (subject == null)
                throw new Exception("Not Found");
            _context.Subjects.Remove(subject);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
