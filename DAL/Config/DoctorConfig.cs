using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCSQLEFCore.Entities;

namespace MVCSQLEFCore.DAL.Config
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(i => i.DoctorId);

            builder.Property(i => i.FirstName)
                .IsRequired();

            builder.Property(i => i.LastName)
                .IsRequired();

            builder.Ignore(i => i.FullName);

            builder.HasOne(a => a.Intern).WithOne(i => i.Doctor).HasForeignKey<Intern>(a=> a.InternId);

            builder.HasMany(c => c.Patients).WithOne(i => i.Doctor);
        }
    }
}

