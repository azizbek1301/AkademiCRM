using MediatR;
using StudyCenter.Domain.Dtos.Admins;

namespace StudyCenter.Service.UseCases.Admins.Commands
{
    public class CreateAdminCommand : CreateAdminDto, IRequest<int>
    {
    }
}
