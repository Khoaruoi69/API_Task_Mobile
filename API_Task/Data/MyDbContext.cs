using API_Task.Models;
using Microsoft.EntityFrameworkCore;
using Task = API_Task.Models.Task;

namespace TodoAPI.Datas
{
    public class MyDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("TodoDbConnectionString"));
        }

        public DbSet<Task> TaskDB { get; set; }
        public DbSet<Todo> TodoDB { get; set; }
        public DbSet<User> UserDB { get; set; }

    }
}
