using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.ProfileControllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        ProfileModel profile = new ProfileModel(){
        Name = "Jessielyn Puli",
        School = "Polytechnic University of the Philippines - Sta. Mesa",
        Program = "Bachelor of Science in Computer Science",
        Address = "San Juan City",
        
        Skills = new string[] {"Canva", "Git/GitHub", "C", "C#"},
        };

        return View(profile);
    }

     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}