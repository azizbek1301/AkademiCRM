using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.UseCases.Teacher_Educations.Command;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Handler
{
    public class UpdateTeacher_EducationHandler : IRequestHandler<UpdateTeacher_EducationCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTeacher_EducationHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateTeacher_EducationCommand request, CancellationToken cancellationToken)
        {
            var studentEdu = await _context.Teacher_Educations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (studentEdu == null)
            {
                throw new Exception("Not Found");
            }
            studentEdu.EducationName = request.EducationName;
            _context.Teacher_Educations.Update(studentEdu);
            return await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
