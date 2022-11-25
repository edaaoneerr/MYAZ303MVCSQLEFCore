using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Config
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(a => a.PatientId);

            builder.Property(a => a.PatientFirstName)
                .IsRequired();

            builder.Property(a => a.PatientLastName)
                .IsRequired();

            builder.Ignore(a => a.PatientFullName);

            
        }
    }
}

