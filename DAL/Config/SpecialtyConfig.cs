using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Config
{
    public class SpecialtyConfig : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.HasKey(a => a.DoctorId);

            builder.Property(a => a.SpecialtyName)
                .IsRequired();

            builder.Property(a => a.NumberOfPatients)
                .IsRequired();

           

        }
    }
}

