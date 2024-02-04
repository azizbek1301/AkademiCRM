using MediatR;

namespace StudyCenter.Service.UseCases.TeacherClasses.Command
{
    public class DeleteTeacherClassesCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
