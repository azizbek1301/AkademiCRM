using MediatR;

namespace StudyCenter.Service.UseCases.Teacher_Educations.Command
{
    public class DeleteTeacher_EducationCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
