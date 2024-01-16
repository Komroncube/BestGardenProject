using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BestGarden.Application.Services;

public interface IFileService
{
    Task<string> SaveFileAsync(IFormFile file);
    Task<bool> DeleteFileAsync(string fileName);
}
