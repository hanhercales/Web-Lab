using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
public class StudentController  :Controller
{
    private List<Student> listStudents = new List<Student>();

    public StudentController()
    {
        listStudents = new List<Student>()
        {
            new Student() {Id = 101, Name = "Hải Nam", Branch = Branch.IT, Gender = Gender.Male, IsRegular = true, Address = "A1-2018", Email = "nam@g.com", Score = 3.6},
            new Student() {Id = 102, Name = "Minh Tú", Branch = Branch.BE, Gender = Gender.Female, IsRegular = true, Address = "A1-2019", Email = "tu@g.com", Score = 7.2},
            new Student() {Id = 103, Name = "Hoàng Phong", Branch = Branch.CE, Gender = Gender.Male, IsRegular = false, Address = "A1-2020", Email = "phong@g.com", Score = 5.3},
            new Student() {Id = 104, Name = "Xuân Mai", Branch = Branch.EE, Gender = Gender.Female, IsRegular = false, Address = "A1-2021", Email = "mai@g.com", Score = 6.2},
        };
    }

    public IActionResult Index()
    {
        return View(listStudents);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
        ViewBag.AllBranches = new List<SelectListItem>()
        {
            new SelectListItem { Text = "IT", Value = "1" },
            new SelectListItem { Text = "BE", Value = "2" },
            new SelectListItem { Text = "CE", Value = "3" },
            new SelectListItem { Text = "EE", Value = "4" }
        };
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Student student)
    {
        if(ModelState.IsValid)
        {
            student.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(student);
            return View("Index", listStudents);
        }

        ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
        
        ViewBag.AllBranches = new List<SelectListItem>()
        {
            new SelectListItem { Text = "IT", Value = "1" },
            new SelectListItem { Text = "BE", Value = "2" },
            new SelectListItem { Text = "CE", Value = "3" },
            new SelectListItem { Text = "EE", Value = "4" }
        };

        return View();
    }

    public IActionResult Branches()
    {
        return View();
    }
    
    public IActionResult Students()
    {
        return View();
    }
    
    public IActionResult Subjects()
    {
        return View();
    }
    
    public IActionResult Courses()
    {
        return View();
    }
}