using MediatR;
using StudyCenter.Domain.Dtos.Subject;

namespace StudyCenter.Service.UseCases.Subjects.Command
{
    public class UpdateSubjectsCommand : SubjectUpdateDto, IRequest<int>
    {
    }
}
