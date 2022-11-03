using AutoMapper;
using CrudFile.AppServices.Shared.Dto;
using CrudFile.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFile.AppServices.Mappers
{
    public class MapperFile:Profile
    {
        public MapperFile()
        {
            CreateMap<ElementFile, FileDto>();
            CreateMap<FileDto, ElementFile>();
        }
    }
}
