using MediatR;

namespace StudyCenter.Service.UseCases.Teachers.Command
{
    public class DeleteTeacherCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
