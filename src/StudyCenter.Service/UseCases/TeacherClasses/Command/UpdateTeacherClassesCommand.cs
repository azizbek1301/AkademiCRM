using MediatR;
using StudyCenter.Domain.Dtos.TeacherClass;

namespace StudyCenter.Service.UseCases.TeacherClasses.Command
{
    public class UpdateTeacherClassesCommand:TeacherClassUpdateDto,IRequest<int>
    {
    }
}
