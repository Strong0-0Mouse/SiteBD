using System;
using System.Collections.Generic;
using System.Linq;
using AndreyTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreyTest.Controllers
{
    [ApiController]
    public class WorkerController : Controller
    {
        private readonly DbManager _dbManager;

        public WorkerController(DbManager dbManager)
        {
            _dbManager = dbManager;
        }

        [Route("addWorker")]
        public IActionResult AddWorker()
        {
            return View();
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("addWorker/action")]
        public IActionResult ActionAddWorker([FromForm] Worker worker)
        {
            _dbManager.AddNewWorker(worker);
            return new RedirectResult("/workerView");
        }
        
        [Route("readWorker")]
        public IActionResult ReadWorker()
        {
            ViewBag.ListWorkers = _dbManager.ReadWorkers();
            return View();
        }
        
        [HttpGet]
        [Route("editWorker")]
        public IActionResult EditWorker(int id = 0)
        {
            ViewBag.IdWorker = id;
            ViewBag.ListWorkers = _dbManager.ReadWorkers();
            if (((List<Worker>)ViewBag.ListWorkers).Count == 0)
                return new RedirectResult("/workerView");
            ViewBag.Worker = id == 0 ? _dbManager.ReadWorkers().First() : _dbManager.ReadWorkers(id).First();
            return View();
        }
        
        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        [Route("editWorker/action")]
        public IActionResult ActionEditWorker([FromForm] Worker worker)
        {
            _dbManager.EditWorker(worker);
            return new RedirectResult("/workerView");
        }
        
        [HttpGet]
        [Route("removeWorker")]
        public IActionResult RemoveWorker(int id = 0)
        {
            _dbManager.RemoveWorker(id);
            ViewBag.ListWorkers = _dbManager.ReadWorkers();
            return View();
        }
    }
}