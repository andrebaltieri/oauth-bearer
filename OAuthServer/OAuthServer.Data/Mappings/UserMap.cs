using OAuthServer.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OAuthServer.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(x => x.Id);
            Property(x => x.Username).IsRequired().HasMaxLength(16);
            Property(x => x.Password).IsRequired().HasMaxLength(32);
        }
    }
}
