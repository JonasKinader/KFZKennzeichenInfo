using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KFZKennzeichenInfo.Models;

namespace KFZKennzeichenInfo.Data
{
    public class KFZKennzeichenInfoContext : DbContext
    {
        public KFZKennzeichenInfoContext (DbContextOptions<KFZKennzeichenInfoContext> options)
            : base(options)
        {
        }

        public DbSet<KFZKennzeichenInfo.Models.KennzeichenInfo> KennzeichenInfo { get; set; } = default!;
    }
}
