using OAuthServer.Data.Mappings;
using OAuthServer.Domain;
using System.Data.Entity;

namespace OAuthServer.Data.DataContexts
{
    public class OAuthServerDataContext : DbContext
    {
        public OAuthServerDataContext()
            : base("OAuthServerConnectionString")
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
