using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OSRSAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRSAPI.Data
{
    public class OSRSDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public OSRSDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
