using FinalMockAssessment6.Models;
using Microsoft.EntityFrameworkCore;


namespace FinalMockAssessment6.Data
{
    public class AppDbContext : DbContext
    {
        //This constructor below identifies the database that we're using. 
        //Entity Framework can work with a number of different databases. 
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        //
        public DbSet<Employee> Employees { get; set; }
    }
}
