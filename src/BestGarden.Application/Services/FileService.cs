using BestGarden.Application.Common.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BestGarden.Application.Services;

public class FileService : IFileService
{
    private const string MEDIA = "media";
    private const string IMAGES = "images";
    private readonly string ROOTPATH;

    public FileService(IWebHostEnvironment environment)
    {
        // ROOTPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        ROOTPATH = environment.WebRootPath;
    }


    public async Task<string> SaveFileAsync(IFormFile file)
    {

        var fileName = MediaHelper.GetImageName(file.FileName);
        var subPath = Path.Combine(MEDIA, IMAGES, fileName);
        var path = Path.Combine(ROOTPATH, subPath);

        await using var stream = new FileStream(path, FileMode.Create);
        await file.CopyToAsync(stream);
        return subPath;
    }

    public async Task<bool> DeleteFileAsync(string filePath)
    {
        string path = Path.Combine(ROOTPATH, filePath);
        if (!File.Exists(path)) return false;

        await Task.Run(() => File.Delete(path));
        return true;
    }
}
