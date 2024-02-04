using MediatR;

namespace StudyCenter.Service.UseCases.Unpaid_Students.Command
{
    public class DeleteunpaidStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
