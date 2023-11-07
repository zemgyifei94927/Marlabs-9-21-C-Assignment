using Microsoft.AspNetCore.Mvc;
using RazorDemos.Models;

namespace RazorDemos.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Person> people = new List<Person>()
            {
            new Person(){ Name = "Tom",
            DateOfBirth = Convert.ToDateTime("1994-06-01"),
            PersonGender = Person.Gender.Male },
            new Person(){ Name = "Peter",
            DateOfBirth = Convert.ToDateTime("1992-06-01"),
            PersonGender = Person.Gender.Male },
            new Person(){ Name = "Mary",
            DateOfBirth = Convert.ToDateTime("1995-06-01"),
            PersonGender = Person.Gender.Female }
            };
            ViewData["people"] = people;
            ViewData["title"] = "Yifei ASP.Net index";
            return View();
        }
    }
}
