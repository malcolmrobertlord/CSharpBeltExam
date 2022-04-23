using Microsoft.EntityFrameworkCore;

namespace CSharpBeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base(options) {}

        //add db tables
        public DbSet<User> Users {get;set;}
        public DbSet<Meeting> Meetings {get;set;}
        public DbSet<Invite> Invites {get;set;}
    }
}