using CrudFile.AppServices.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFile.AppServices.FileManager
{
    public interface IManagerFileServices
    {
        Task<FileDto> CreateFileAsync(FileDto fileDto);
        Task<FileDto> DeleteFileAsync(FileDto fileDto);

        Task<FileDto> GetFileByIdAsync(int id);
    }
}
