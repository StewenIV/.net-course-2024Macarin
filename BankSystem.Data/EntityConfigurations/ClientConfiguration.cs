using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankSystem.Data.EntityConfigurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Clients")
            .Ignore(c => c.Age);
        builder.HasMany(c => c.Accounts)
            .WithOne(a => a.Client)
            .HasForeignKey(a => a.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasKey(e => e.Id)
            .HasName("id_client");
        builder.Property(e => e.Id)
            .HasColumnName("id_client");
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.Surname)
            .HasColumnName("surname")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.PhoneNumber)
            .HasColumnName("phone_number")
            .IsRequired();
        builder.Property(e => e.Email)
            .HasColumnName("email")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.Address)
            .HasColumnName("address")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.PassportDetails)
            .HasColumnName("passport_details")
            .IsRequired();
        builder.Property(e => e.BirthDate)
            .HasColumnName("birth_date")
            .IsRequired();
        builder.Property(e => e.Bonus)
            .HasColumnName("bonus");
        builder.Property(c => c.OrderAmount)
            .HasColumnName("order_amount")
            .IsRequired();
        builder.Property(c => c.OrderNumber)
            .HasColumnName("order_number")
            .IsRequired();
        builder.HasIndex(e => e.Email)
            .IsUnique()
            .HasDatabaseName("email_unique_client");
    }
}