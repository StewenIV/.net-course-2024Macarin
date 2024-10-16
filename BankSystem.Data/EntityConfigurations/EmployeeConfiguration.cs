using BankSystem.Dom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankSystem.Data.EntityConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees")
            .Ignore(e => e.Contract)
            .Ignore(e => e.Age);
        builder.ToTable(t => t.HasCheckConstraint("ValidAge",
            "DATE_PART('year', AGE(birth_date)) > 0 AND DATE_PART('year', AGE(birth_date)) < 100"));

        builder.HasKey(e => e.Id)
            .HasName("id_employee");
        builder.Property(e => e.Id)
            .HasColumnName("id_employee");
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
        builder.Property(e => e.Position)
            .HasColumnName("position")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(e => e.StartDate)
            .HasColumnName("start_date")
            .IsRequired();
        builder.Property(e => e.EndDate)
            .HasColumnName("end_date");
        builder.Property(e => e.Salary)
            .HasColumnName("salary")
            .IsRequired();
        builder.HasIndex(e => e.Email)
            .IsUnique()
            .HasDatabaseName("email_unique_employee");
    }
}