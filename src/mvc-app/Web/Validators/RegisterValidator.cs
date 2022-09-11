using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Web.Models;
using Web.ViewModels;

namespace Web.Validators;

public class RegisterValidator : AbstractValidator<RegisterViewModel>
{
    public RegisterValidator(UserManager<User> userManager)
    {
    }
}