using Domain;
using Infrastructure.EntitiesConfiguration.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration;

public class PartnerEntityConfiguration : BaseEntityConfiguration<Partner>
{
    public override void Configure(EntityTypeBuilder<Partner> builder)
    {
        base.Configure(builder);

        builder.ToTable("Partners");

        builder.Property(e => e.Name)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(e => e.SurName)
            .HasColumnName("surname")
            .IsRequired();

        builder.Property(e => e.DateOfBirth)
            .HasColumnName("date_of_birth")
            .IsRequired();

        builder.Property(e => e.UserName)
            .HasColumnName("username")
            .IsRequired();

        builder.Property(e => e.Password)
            .HasColumnName("password")
            .IsRequired();
    }
}