using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Web.Models;
using Web.ViewModels;

namespace Web.Validators;

public class LoginValidator : AbstractValidator<LoginViewModel>
{
    public LoginValidator(UserManager<User> userManager)
    {
        RuleFor(x => new { x.PassWord, x.UserName }).Must(x =>
          {
              var user = userManager.FindByNameAsync(x.UserName).Result;
              if (user is null) return false;
              var result = userManager.PasswordHasher.VerifyHashedPassword(user, user.PasswordHash, x.PassWord);
              return result == PasswordVerificationResult.Success;
          }).WithMessage("Tên đăng nhập hoặc mật khẩu không đúng");
    }
}