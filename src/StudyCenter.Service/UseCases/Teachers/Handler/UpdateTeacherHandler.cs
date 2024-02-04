using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teachers.Command;

namespace StudyCenter.Service.UseCases.Teachers.Handler
{
    public class UpdateTeacherHandler : IRequestHandler<UpdateTeacherCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTeacherHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            teacher.FullName = request.FullName;
            teacher.Address = request.Address;
            teacher.SubjectName = request.SubjectName;
            teacher.PhoneNumber = request.PhoneNumber;
            teacher.Education_id = request.Education_id;
            teacher.About = request.About;
            teacher.Email = request.Email;
            _context.Teachers.Update(teacher);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
