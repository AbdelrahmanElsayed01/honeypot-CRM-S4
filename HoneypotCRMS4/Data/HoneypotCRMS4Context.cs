using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoneypotCRMS4.Models;

namespace HoneypotCRMS4.Data
{
    public class HoneypotCRMS4Context : DbContext
    {
        public HoneypotCRMS4Context (DbContextOptions<HoneypotCRMS4Context> options)
            : base(options)
        {
        }

        public DbSet<HoneypotCRMS4.Models.UserModel> UserModel { get; set; } = default!;
    }
}
