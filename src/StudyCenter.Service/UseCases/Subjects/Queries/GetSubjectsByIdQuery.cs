using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Subjects.Queries
{
    public class GetSubjectsByIdQuery : IRequest<Subject>
    {
        public int Id { get; set; }
    }
}
