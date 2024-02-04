using MediatR;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teachers.Command;

namespace StudyCenter.Service.UseCases.Teachers.Handler
{
    public class CreateTeacherHandler : IRequestHandler<CreateTeacherCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTeacherHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTeacherCommand request, CancellationToken cancellationToken)
        {
            var teacher = new Teacher()
            {
                 FullName=request.FullName, 
                 SubjectName=request.SubjectName, 
                 PhoneNumber =request.PhoneNumber,
                 Email=request.Email, 
                 Address = request.Address,
                 About = request.About,
                 Education_id = request.Education_id,
            };
            await _context.Teachers.AddAsync(teacher);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
