using Microsoft.AspNetCore.Mvc;
using Magazyn.Web.Services;

namespace Magazyn.Web.Controllers;

public class KsiazkiController : Controller
{
    private readonly IBookService _bookService;

    public KsiazkiController(IBookService bookService)
    {
        _bookService = bookService;
    }

    public IActionResult Index()
    {
        var ksiazki = _bookService.GetAll();
        return View(ksiazki);
    }
}
