using System.Data.Entity;

namespace UserLogin
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Log> Logs { get; set; }

        public UserContext()
        {
            if (!Database.Exists())
            {

            }
        }
    }
}