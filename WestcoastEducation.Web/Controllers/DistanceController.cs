using Microsoft.AspNetCore.Mvc;
using WestcoastEducation.Web.Models;

namespace WestcoastEducation.Web.Controllers;

[Route("distance")]
public class DistanceController : Controller
{
    public IActionResult Index()
    {
        var distance = new List<Distance>
        {
            new Distance() {Name = "Rymdfysik 1", Content = "Historisk introduktion till rymdplasmafysiken"}
        };

        return View("Index", distance);
    }
}
