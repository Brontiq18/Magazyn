using Microsoft.AspNetCore.Mvc;

namespace Magazyn.Web.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
