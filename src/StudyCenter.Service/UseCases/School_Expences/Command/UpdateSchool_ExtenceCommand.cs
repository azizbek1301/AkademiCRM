using MediatR;
using StudyCenter.Domain.Dtos.School_Expence;

namespace StudyCenter.Service.UseCases.School_Expences.Command
{
    public class UpdateSchool_ExtenceCommand:School_ExpenceUpdateDto,IRequest<int>
    {
    }
}
