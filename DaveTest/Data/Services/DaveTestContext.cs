using DaveTest.Data.Repositories.EF_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DaveTest.Data.Services
{
    public class DaveTestContext : DbContext
    {
        public DaveTestContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<vUser> VUser { get; set; }
    }
}