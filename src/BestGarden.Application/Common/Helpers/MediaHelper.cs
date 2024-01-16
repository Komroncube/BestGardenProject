namespace BestGarden.Application.Common.Helpers;
public static class MediaHelper
{
    public static string GetImageName(string filename)
    {
        var fileInfo = new FileInfo(filename);
        string extension = fileInfo.Extension;
        string name = "IMG_" + Guid.NewGuid() + extension;
        return name;
    }
}
