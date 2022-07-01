using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRSAPI.Data
{
    public class OSRSDbContext: DbContext
    {
        public OSRSDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
