using MediatR;
using StudyCenter.Domain.Dtos.Teacher;

namespace StudyCenter.Service.UseCases.Teachers.Command
{
    public class UpdateTeacherCommand : TeacherUpdateDto, IRequest<int>
    {
    }
}
