using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Subjects.Queries
{
    public class GetAllSubjectsQuery:IRequest<List<Subject>>
    {
    }
}
