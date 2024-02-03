using MediatR;
using StudyCenter.Domain.Dtos.Events;

namespace StudyCenter.Service.UseCases.Event.Command
{
    public class CreateEventCommand:EventCreateDto,IRequest<int>
    {
    }
}
