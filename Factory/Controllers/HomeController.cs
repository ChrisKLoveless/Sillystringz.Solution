using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Engineer [] engineers = _db.Engineers.ToArray();
      Machine[] machines = _db.Machines.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("Engineers", engineers);
      model.Add("Machines", machines);
      return View(model);
    }
  }
}