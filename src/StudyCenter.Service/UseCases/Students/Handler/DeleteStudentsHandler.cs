using MediatR;
using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;
using StudyCenter.Service.Abstraction.File;
using StudyCenter.Service.UseCases.Students.Command;

namespace StudyCenter.Service.UseCases.Students.Handler
{
    public class DeleteStudentsHandler : IRequestHandler<DeleteStudentsCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public DeleteStudentsHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<int> Handle(DeleteStudentsCommand request, CancellationToken cancellationToken)
        {
            Student? student = await _context.Students.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (student == null)
            {
                throw new Exception("Not Found");
            }
            try
            {
                student.EndDate= DateTime.UtcNow;
                await _fileService.DeleteImageAsync(student.ImageUrl);
            }
            catch
            {
                throw new Exception("Not Found");
            }
            _context.Students.Remove(student);
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
