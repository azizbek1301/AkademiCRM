using MediatR;
using StudyCenter.Domain.Dtos.Teacher_Education;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Command
{
    public class UpdateTeacher_EducationCommand : TeacherEduUpdateDto, IRequest<int>
    {
    }
}
