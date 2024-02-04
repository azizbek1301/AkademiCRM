using MediatR;

namespace StudyCenter.Service.UseCases.Food_Categories.Command
{
    public class DeleteFood_CategoryCommand:IRequest<int>
    {
        public int Id { get; set; } 
    }
}
