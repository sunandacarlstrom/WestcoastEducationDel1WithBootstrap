using Microsoft.AspNetCore.Mvc;
using WestcoastEducation.Web.Models;

namespace WestcoastEducation.Web.Controllers;

[Route("onDemand")]
public class OnDemandController : Controller
{
    public IActionResult Index()
    {
        var ondemand = new List<OnDemand>{
            new OnDemand() { Name = "Förskola", Content = "Barns språkliga lärande och kommunikation i förskolan"},
            new OnDemand() { Name = "Specialpedagogik i förskolan", Content = "Olika funktionsnedsättningar, exempelvis neuropsykiatriska funktionsnedsättningar"},
            };

        return View("Index", ondemand);
    }
}
