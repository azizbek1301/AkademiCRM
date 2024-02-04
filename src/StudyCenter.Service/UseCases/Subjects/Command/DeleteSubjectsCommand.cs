using MediatR;

namespace StudyCenter.Service.UseCases.Subjects.Command
{
    public class DeleteSubjectsCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
