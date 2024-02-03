using MediatR;
using StudyCenter.Domain.Models;

namespace StudyCenter.Service.UseCases.Event.Queries
{
    public class GetEventByIdQuery:IRequest<Events>
    {
        public int Id {  get; set; }

    }
}
