using MediatR;
using StudyCenter.Domain.Dtos.Admins;

namespace StudyCenter.Service.UseCases.Admins.Commands
{
    public class UpdateAdminCommand : UpdateAdminDto, IRequest<int>
    {
    }
}
