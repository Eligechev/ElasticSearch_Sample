using System.Data.Entity;

namespace WebApplication1   
{
    public class CollegeDbContext : DbContext
    {
        public CollegeDbContext() : base("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=TeamLab_Cashback; ")
        {
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Model> Models { get; set; }
    }
}