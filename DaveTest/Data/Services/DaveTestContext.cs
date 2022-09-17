using DaveTest.Data.Repositories.EF_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DaveTest.Data.Services
{
    public class DaveTestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb); Initial Catalog=DaveTest; User Id=[DaveTestAccount]; Password=myTestAccount123");
        }

        public virtual DbSet<vUser> VUser { get; set; }
        public virtual int usp_UserUpsert(int userID, string userFirstName, string userLastName, string userAddress, int userAge, string userPhoneNumber)
        {
            return 0;
        }

        public virtual int usp_UserDelete(int userID, string userFirstName, string userLastName, string userAddress, int userAge, string userPhoneNumber)
        {
            return 0;
        }
    }
}