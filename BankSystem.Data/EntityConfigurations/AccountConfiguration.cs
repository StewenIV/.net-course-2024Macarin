using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankSystem.Data.EntityConfigurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts").Ignore(a => a.Currency);

        builder.HasKey(e => e.Id)
            .HasName("id_account");
        builder.Property(e => e.Id)
            .HasColumnName("id_account");
        builder.Property(e => e.CurrencyName)
            .HasColumnName("currency_name")
            .IsRequired();
        builder.Property(e => e.Amount)
            .HasColumnName("amount")
            .IsRequired();
    }
}