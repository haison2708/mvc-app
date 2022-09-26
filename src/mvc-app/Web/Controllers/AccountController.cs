using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web.IRepository;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers;

public class AccountController : BaseController
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IValidator<LoginViewModel> _loginValidator;

    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IUnitOfWork unitOfWork, IValidator<LoginViewModel> loginValidator, IMapper mapper) : base(unitOfWork, mapper)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _loginValidator = loginValidator;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Register()
    {
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromForm] RegisterViewModel registerViewModel)
    {

        var existUser = await _userManager.FindByNameAsync(registerViewModel.UserName);

        if (existUser != null)
        {
            var user = new User
            {
                UserName = registerViewModel.UserName,
                Email = registerViewModel.Email,
                PhoneNumber = registerViewModel.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, registerViewModel.PassWord);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
        }
        @ViewData["ErrorRegiste"] = "Tên đăng nhập đã tồn tại";
        return View();
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Login(string returnUrl)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromForm] LoginViewModel loginViewModel, string returnUrl)
    {
        ViewBag.ReturnUrl = returnUrl;
        var result = await _loginValidator.ValidateAsync(loginViewModel);
        if (result.IsValid)
        {
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            await _signInManager.SignInAsync(user, isPersistent: false);
            RedirectToReturnUrl(returnUrl);
        }
        ViewData["ErrorLogin"] = result.Errors.FirstOrDefault();

        return View(loginViewModel);
    }

    [HttpGet]
    public async Task<IActionResult> LogOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login", "Account");
    }

    private IActionResult RedirectToReturnUrl(string returnUrl)
    {
        if (Url.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        return RedirectToAction("Index", "Home");
    }
}