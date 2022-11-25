using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Config
{

    public class InternConfig : IEntityTypeConfiguration<Intern>
        {
            public void Configure(EntityTypeBuilder<Intern> builder)
            {
                builder.HasKey(a => a.InternId);

                builder.Property(a => a.FirstName)
                    .IsRequired();

                builder.Property(a => a.LastName)
                    .IsRequired();

                builder.Ignore(a => a.FullName);

            }
        }
}

