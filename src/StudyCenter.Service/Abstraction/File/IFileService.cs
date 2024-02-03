using Microsoft.AspNetCore.Http;
namespace StudyCenter.Service.Abstraction.File
{
    public interface IFileService
    {
        ValueTask<string> UploadImageAsync(IFormFile file);
        ValueTask<bool> DeleteImageAsync(string file);
        ValueTask<byte[]> GetImageAsync(string path);

    }
}
