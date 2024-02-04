using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Teachers.Queries
{
    public class GetTeacherByIdQuery : IRequest<Teacher>
    {
        public int Id { get; set; }
    }
}
