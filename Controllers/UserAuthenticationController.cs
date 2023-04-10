using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Models.DTO;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private IUserAuthenticationService authservice;
        public UserAuthenticationController(IUserAuthenticationService authservice)
        {
            this.authservice = authservice;
        }
        /* We Will create a user with admin rights, after that we are going to comment this method as we need only one user in this application */
        //public async Task<IActionResult> Register()
        //{
        //    var model = new RegistrationModel
        //    {
        //        Email = "admin@gmail.com",
        //        Username = "admin",
        //        Name = "Achyuth",
        //        Password = "Admin@123",
        //        PasswordConfirm = "Admin@123",
        //        Role = "Admin",
        //    };
        //    var result = await authservice.RegisterAsync(model);
        //    return Ok(result.Message);
        //}

        //public async Task<IActionResult> Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return View(model);

        //    var result = await authservice.LoginAsync(model);
        //    if (result.StatusCode == 1)
        //        return RedirectToAction("Index", "Home");
        //    else
        //    {
        //        TempData["msg"] = "Could not logged in..";
        //        return RedirectToAction(nameof(Login));
        //    }
        //}

        //public async Task<IActionResult> Logout()
        //{
        //    await authservice.LogoutAsync();
        //    return RedirectToAction(nameof(Login));
        //}
    }
}