using MediatR;

namespace StudyCenter.Service.UseCases.Students.Command
{
    public class DeleteStudentsCommand:IRequest<int>
    {
        public int Id { get; set; }     
    }
}
