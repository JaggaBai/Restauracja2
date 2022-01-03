using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data
{
    public class RestDbContext : DbContext
    {
        public RestDbContext(DbContextOptions<RestDbContext> options) :base(options)
        {

        }
    }
}
