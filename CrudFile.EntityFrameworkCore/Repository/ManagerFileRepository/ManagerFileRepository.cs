using CrudFile.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFile.EntityFrameworkCore.Repository.ManagerFileRepository
{
    public class ManagerFileRepository:Repository<int,ElementFile>
    {
        public ManagerFileRepository(CrudFileDbContext context):base(context)
        {

        }
    }
}
