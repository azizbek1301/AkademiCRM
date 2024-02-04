using MediatR;
using StudyCenter.Domain.Dtos.School_Expence;

namespace StudyCenter.Service.UseCases.School_Expences.Command
{
    public class CreateSchool_ExpenceCommand:School_ExpenceCreateDto,IRequest<int>
    {
    }
}
