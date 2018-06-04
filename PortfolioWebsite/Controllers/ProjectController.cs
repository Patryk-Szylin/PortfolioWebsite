using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioWebsite.Models;

namespace PortfolioWebsite.Controllers
{
    public class ProjectController : Controller
    {
        ProjectModelView project = new ProjectModelView
        {
            ID = 1,
            Type = 0,
            ProjectTitle = "3Ds max in a nutshell",
            ImageUrl = "https://i.imgur.com/XYkHnJl.jpg",
            Description = "This is my initial project in 3Ds max"
        };

        ProjectModelView project2 = new ProjectModelView
        {
            ID = 2,
            Type = 0,
            ProjectTitle = "Java in cafe",
            ImageUrl = "https://i.imgur.com/Loya5z4.jpg",
            Description = "Internet Cafe project made in Javascript"
        };

        ProjectModelView project3 = new ProjectModelView
        {
            ID = 3,
            Type = PROJECT_TYPE.GAME,
            ProjectTitle = "Top notch game",
            ImageUrl = "https://i.imgur.com/Loya5z4.jpg",
            Description = "This is my first game"
        };

        List<ProjectModelView> projects = new List<ProjectModelView>();

        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProjectDetails(int id)
        {
            projects.Add(project);
            projects.Add(project2);
            projects.Add(project3);

            var pro = projects.FirstOrDefault(p => p.ID == id);

            return View(pro);
        }

    }
}
