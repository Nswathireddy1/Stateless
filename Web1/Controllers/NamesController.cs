using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web1.Controllers
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string College { get; set; }
        public string Address { get; set; }


    }

    [Route("api/[Controller]")]
    public class NamesController : Controller
    {

        List<Student> geographies = new List<Student>();
        public IActionResult Index()
        {
            geographies.Add(new Student() { ID = 1, FirstName = "mahesh",LastName="pothuluru",College="SVCE",Address="temple" });
            geographies.Add(new Student() { ID = 2, FirstName = "naresh",LastName="Reddy" ,College="SVCE",Address="hindupur"});
            geographies.Add(new Student() { ID = 3, FirstName = "SWathiReddy", LastName = "Nara", College = "SVCE", Address = "punganur" });
            geographies.Add(new Student() { ID = 4, FirstName = "Prasanth", LastName = "Reddy", College = "AITS", Address = "Mpl" });




            return new JsonResult(geographies);
        }
    }
}