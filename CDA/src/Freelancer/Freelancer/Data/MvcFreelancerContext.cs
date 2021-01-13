using Freelancer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Data
{
    public class MvcFreelancerContext : DbContext
    {
        public MvcFreelancerContext(DbContextOptions<MvcFreelancerContext> options)
           : base(options)
        {
        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<Devis> Devis { get; set; }

    }
}

