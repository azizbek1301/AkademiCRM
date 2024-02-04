using MediatR;

namespace StudyCenter.Service.UseCases.School_Expences.Command
{
    public class DeleteSchool_ExtenceCommand:IRequest<int>
    {
        public int Id { get; set; } 
    }
}
