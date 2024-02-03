using MediatR;

namespace StudyCenter.Service.UseCases.Event.Command
{
    public class DeleteEvenetCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
