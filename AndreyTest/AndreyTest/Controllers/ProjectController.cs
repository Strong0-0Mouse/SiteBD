using System.Collections.Generic;
using System.Linq;
using AndreyTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreyTest.Controllers
{
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly DbManager _dbManager;
        private static int _currentProjectId;

        public ProjectController(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        
        [Route("addProject")]
        public IActionResult AddProject([FromForm] Project project)
        {
            return View();
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("addProject/action")]
        public IActionResult AddProjectAction([FromForm] Project project)
        {
            _dbManager.AddNewProject(project);
            return new RedirectResult("/projectView");
        }

        [Route("readProject")]
        public IActionResult ReadProject(int idAction = 0)
        {
            ViewBag.ListProjects = _dbManager.ReadProjects(idAction: idAction);
            return View();
        }
        
        [HttpGet]
        [Route("editProject")]
        public IActionResult EditProject(int id = 0)
        {
            ViewBag.IdWorker = id;
            ViewBag.ListProjects = _dbManager.ReadProjects();
            ViewBag.ListWorkers = _dbManager.ReadWorkers();
            if (((List<Project>)ViewBag.ListProjects).Count == 0)
                return new RedirectResult("/projectView");
            ViewBag.Project = id == 0 ? _dbManager.ReadProjects().First() : _dbManager.ReadProjects(id).First();
            _currentProjectId = id;
            return View();
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("editProject/action")]
        public IActionResult ActionEditProject([FromForm] Project project)
        {
            _dbManager.EditProject(project);
            return new RedirectResult("/projectView");
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("editLeaderProject/action")]
        public IActionResult ActionEditLeaderProject([FromForm] int idLeader)
        {
            var project = _dbManager.ReadProjects(_currentProjectId).First();
            var leader = _dbManager.ReadWorkers(idLeader).First();
            _dbManager.EditProject(project, leader, idAction: 1);
            return new RedirectResult("/projectView");
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("editPerformersProject/action")]
        public IActionResult ActionEditPerformersProject([FromForm] List<int> idPerformers)
        {
            var project = _dbManager.ReadProjects(_currentProjectId).First();
            var performers = idPerformers.Select(id => _dbManager.ReadWorkers(id).First()).ToList();
            _dbManager.EditProject(project, performers: performers, idAction: 2);
            return new RedirectResult("/projectView");
        }
        
        [HttpGet]
        [Route("removeProject")]
        public IActionResult RemoveProject(int id = 0)
        {
            _dbManager.RemoveProject(id);
            ViewBag.ListProjects = _dbManager.ReadProjects();
            return View();
        }
    }
}