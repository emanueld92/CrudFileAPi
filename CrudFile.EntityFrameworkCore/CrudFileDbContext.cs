using CrudFile.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudFile.EntityFrameworkCore
{
    public class CrudFileDbContext:IdentityDbContext
    {
        public virtual DbSet<ElementFile> ElementFiles { get; set; }
        public CrudFileDbContext(DbContextOptions<CrudFileDbContext> options):base(options)
        {

        }
    }
}
