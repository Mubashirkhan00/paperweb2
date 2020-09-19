
using System.Data.Entity;


namespace studentDetail.Models
{
    public class Students
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
    }
}