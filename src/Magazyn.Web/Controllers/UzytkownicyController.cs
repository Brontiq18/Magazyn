using Microsoft.AspNetCore.Mvc;
using Magazyn.Web.Services;

namespace Magazyn.Web.Controllers;

public class UzytkownicyController : Controller
{
    private readonly IUserService _userService;

    public UzytkownicyController(IUserService userService)
    {
        _userService = userService;
    }

    public IActionResult Index()
    {
        var uzytkownicy = _userService.GetAll();
        return View(uzytkownicy);
    }
}
