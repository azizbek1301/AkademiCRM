using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Event.Queries
{
    public class GetAllEventQuery:IRequest<IEnumerable<Events>>
    {
    }
}
