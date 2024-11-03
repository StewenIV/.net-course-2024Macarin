using BankSystem.Appl.DTOs;
using FluentValidation;

namespace BankSystem.Appl.Validators;

public class ClientDtoValidator : AbstractValidator<ClientDto>
{
    public ClientDtoValidator()
    {
        RuleFor(c => c.FullName)
            .NotNull()
            .NotEmpty()
            .WithMessage("Имя пользователя обязательно.")
            .MaximumLength(100).WithMessage("Имя пользователя не должно превышать 100 символов.");

        RuleFor(c => c.PhoneNumber)
            .NotNull()
            .NotEmpty()
            .WithMessage("Номер телефона обязателен.")
            .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number format.");

        RuleFor(c => c.Email)
            .NotNull()
            .NotEmpty()
            .WithMessage("Email обязателен.")
            .EmailAddress().WithMessage("Неверный формат email.");
        
        RuleFor(c => c.Address)
            .NotNull()
            .NotEmpty()
            .WithMessage("Адрес обязателен.");
        
        RuleFor(c => c.PassportDetails)
            .NotEmpty()
            .NotNull()
            .WithMessage("Паспортные данные обязательны.");
        
        RuleFor(c => c.BirthDate)
            .NotEmpty()
            .NotNull()
            .WithMessage("Дата рождения обязательна.")
            .Must(BeAValidAge).WithMessage("Возраст должен быть от 18 до 99 лет.");
       
        RuleFor(c => c.OrderNumber)
            .NotNull()
            .NotEmpty()
            .Must(o => o > 0).WithMessage("Номер заказа должен быть больше 0.");

        RuleFor(c => c.OrderAmount)
            .NotNull()
            .NotEmpty()
            .WithMessage("Сумма заказа обязательна.")
            .Must(o => o >= 0).WithMessage("Номер заказа должен быть больше 0.");
    }
    private bool BeAValidAge(DateTime birthDate)
    {
        int age = DateTime.Now.Year - birthDate.Year;
        return age >= 18 && age <= 99;
    }
}