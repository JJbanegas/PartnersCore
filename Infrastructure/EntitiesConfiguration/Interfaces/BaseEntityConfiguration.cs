using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntitiesConfiguration.Interfaces;

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey("Id");

        builder.Property<int>("Id")
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property<Guid>("Uuid")
            .HasColumnName("uuid")
            .IsRequired(true)
            .HasDefaultValueSql("NEWID()");

        builder.Property<DateTime>("CreatedAt")
            .HasColumnName("created_at")
            .IsRequired(true)
            .HasDefaultValueSql("GETDATE()");

        builder.Property<DateTime>("UpdatedAt")
            .HasColumnName("updated_at")
            .IsRequired(true)
            .HasDefaultValueSql("GETDATE()");
    }
}