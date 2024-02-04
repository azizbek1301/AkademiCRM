using MediatR;
using StudyCenter.Domain.Dtos.Teacher;

namespace StudyCenter.Service.UseCases.Teachers.Command
{
    public class CreateTeacherCommand:TeacherCreateDto,IRequest<int>
    {
    }
}
