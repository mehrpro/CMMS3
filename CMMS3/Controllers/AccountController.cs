using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CMMS3.Models.Entities;
using CMMS3.Models.ViewModels;
using Microsoft.AspNetCore.Identity;


namespace NetSystem.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<UserApplication> _userManager;
        private readonly SignInManager<UserApplication> _signInManager;

        public AccountController(UserManager<UserApplication> userManager, SignInManager<UserApplication> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Index()
        {
            return Redirect("/home");
        }


        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Home");

            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Home");

            ViewData["returnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                var result =
                    await _signInManager
                        .PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return RedirectToAction("Index", "Home");
                }
                if (result.IsLockedOut)
                {
                    ViewData["ErrorMessage"] = "اکانت شما به دلیل پنج بار ورود ناموفق به مدت پنج دقیقه قفل شده است";
                    return View(model);
                }

                ModelState.AddModelError("", "رمزعبور یا نام کاربری اشتباه است");
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([Bind("UserName,Password,ConfirmPassword,Email")] RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new UserApplication()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    EmailConfirmed = true
                };
                var identityResult = await _userManager.CreateAsync(newUser, model.Password);
                if (identityResult.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in identityResult.Errors) ModelState.AddModelError(error.Code, error.Description);
            }
            return View(model);
        }









        /////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IsEmailAvailable(string email)
        {
            var result = await _userManager.FindByEmailAsync(email);
            return result == null ? Json(true) : Json("این ایمیل قبلاً ثبت شده است");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IsUserNameAvailable(string username)
        {
            var result = await _userManager.FindByNameAsync(username);
            return result == null ? Json(true) : Json("این نام کاربری قبلاً ثبت شده است");
        }

    }
}
