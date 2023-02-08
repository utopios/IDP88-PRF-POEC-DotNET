using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TP03.Datas;
using TP03.Models;
using TP03.Models.ViewModels;
using TP03.Services;

namespace TP03.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository<WebAppUser> _webAppUserRepository;
        private readonly OrderService _orderService;

        public AccountController(IRepository<WebAppUser> webAppUserRepository, OrderService orderService)
        {
            _webAppUserRepository = webAppUserRepository;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(CredentialVM vm)
        {
            if (!ModelState.IsValid) return View();

            // Verify the credential
            List<WebAppUser> users = _webAppUserRepository.GetAll();

            WebAppUser userFound = users.FirstOrDefault(x => x.UserName == vm.UserName && x.Password == vm.Password);
            if (userFound is not null)
            {
                // Creating the security context
                var claims = userFound.Claims;

                var identity = new ClaimsIdentity(claims, "CookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = vm.RememberMe
                };

                await HttpContext.SignInAsync("CookieAuth", claimsPrincipal, authProperties);

                return RedirectToAction("Index", "Books");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            _orderService.EmptyCart();
            await HttpContext.SignOutAsync("CookieAuth");
            return RedirectToAction("Index", "Books");
        }
    }
}
