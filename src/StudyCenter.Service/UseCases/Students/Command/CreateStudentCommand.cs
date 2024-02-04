using MediatR;
using StudyCenter.Domain.Dtos.Student;

namespace StudyCenter.Service.UseCases.Students.Command
{
    public class CreateStudentCommand : StudentCreateDto, IRequest<int>
    {
    }
}
