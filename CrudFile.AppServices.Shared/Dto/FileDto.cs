using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CrudFile.AppServices.Shared.Dto
{
    public class FileDto

    {
       
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string Description { get; set; }
       
        public string ImageName { get; set; }
   
        public IFormFile ImageFile { get; set; }
    }
}
