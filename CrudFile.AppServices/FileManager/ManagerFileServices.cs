using AutoMapper;
using CrudFile.AppServices.Shared.Dto;
using CrudFile.Core;
using CrudFile.EntityFrameworkCore.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrudFile.AppServices.FileManager
{

    public class ManagerFileServices : IManagerFileServices
    {
    private readonly IMapper _mapper;
    private readonly IRepository<int, ElementFile> _repository;
    private IHostingEnvironment _environment;

        public ManagerFileServices(IMapper mapper, IRepository<int, ElementFile> repository, IHostingEnvironment environment)
        {
            _environment = environment;
            _mapper = mapper;
            _repository = repository;
        }
      
        private string UpLoadFile(FileDto fileDto)
        {
            string fileName = null;

            if(fileDto.ImageFile != null)
            {
                string wwwRootPath = _environment.WebRootPath;
                fileName = Path.GetFileNameWithoutExtension(fileDto.ImageFile.FileName);
                string extension = Path.GetExtension(fileDto.ImageFile.FileName);
                fileDto.ImageName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/image/", fileName);
                using(var fileStream= new FileStream(path, FileMode.Create))
                {
                    fileDto.ImageFile.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public async Task<FileDto> CreateFileAsync(FileDto fileDto)
        {
            fileDto.Name = UpLoadFile(fileDto);

            ElementFile _mapperFile= _mapper.Map<ElementFile>(fileDto);
            var r = await _repository.AddAsync(_mapperFile);
            return _mapper.Map<FileDto>(r);
        }

        public Task<FileDto> DeleteFileAsync(FileDto fileDto)
        {
            throw new NotImplementedException();
        }

        public Task<FileDto> GetFileByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
