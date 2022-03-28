using System;
using System.Collections.Generic;
using System.Linq;
using AndreyTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AndreyTest
{
    public class DbManager
    {
        private readonly ProjectDbContext _dbContext;

        public DbManager(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void AddNewProject(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }
        
        public void AddNewWorker(Worker worker)
        {
            _dbContext.Workers.Add(worker);
            _dbContext.SaveChanges();
        }

        public List<Project> ReadProjects(int id = 0, int idAction = 0)
        {
            List<Project> listProjects;
            if (id == 0)
            {
                listProjects = _dbContext.Projects.ToList();
                foreach (var project in listProjects)
                {
                    _dbContext.Entry(project).Reference("Leader").Load();
                    _dbContext.Entry(project).Collection("Performers").Load();
                    foreach (var performer in project.Performers)
                        _dbContext.Entry(performer).Reference("Worker").Load();
                }
            }
            else
            {
                listProjects = _dbContext.Projects.Where(p => p.Id == id).ToList();
                foreach (var project in listProjects)
                {
                    _dbContext.Entry(project).Reference("Leader").Load();
                    _dbContext.Entry(project).Collection("Performers").Load();
                    foreach (var performer in project.Performers)
                        _dbContext.Entry(performer).Reference("Worker").Load();
                }
            }
            return listProjects;
        }

        public List<Worker> ReadWorkers(int id = 0) =>
            id == 0 
                ? _dbContext.Workers.ToList() 
                : _dbContext.Workers.Where(w => w.Id == id).ToList();
        
        public void EditWorker(Worker worker)
        {
            var currentWorker = _dbContext.Workers.First(w => w.Id == worker.Id);
            currentWorker.Name = worker.Name;
            currentWorker.SecondName = worker.SecondName;
            currentWorker.Patronymic = worker.Patronymic;
            currentWorker.Email = worker.Email;
            _dbContext.SaveChanges();
        }
        
        public void EditProject(Project project, Worker leader = null, List<Worker> performers = null, int idAction = 0)
        {
            var currentProject = _dbContext.Projects.First(w => w.Id == project.Id);
            var currentAppointment = _dbContext.Appointments;
            var listAppointment = _dbContext.Appointments.ToList();
            switch (idAction)
            {
                case 0:
                    currentProject.NameProject = project.NameProject;
                    currentProject.NameCustomerCompany = project.NameCustomerCompany;
                    currentProject.NamePerformingCompany = project.NamePerformingCompany;
                    currentProject.StartTime = project.StartTime;
                    currentProject.EndTime = project.EndTime;
                    currentProject.Priority = project.Priority;
                    break;
                case 1:
                    currentProject.Leader = leader;
                    break;
                case 2:
                    if (performers != null)
                        foreach (var performer in performers)
                        {
                            var appointment = new Appointment
                            {
                                Worker = performer,
                                Project = currentProject
                            };
                            if (listAppointment.Count == 0 || listAppointment.Find(a => a == appointment) == null)
                                currentAppointment.Add(appointment);
                            else
                            {
                                currentAppointment.First(a => a == appointment).Project = currentProject;
                                currentAppointment.First(a => a == appointment).Worker = performer;
                            }
                        }

                    break;
            }
            _dbContext.SaveChanges();
        }
        
        public void RemoveWorker(int id)
        {
            if (id == 0) return;
            _dbContext.Workers.Remove(
                _dbContext.Workers.First(w => w.Id == id));
            _dbContext.Appointments.RemoveRange(
                _dbContext.Appointments.Where(a => a.Worker.Id == id));
            _dbContext.SaveChanges();
        }
        
        public void RemoveProject(int id)
        {
            if (id == 0) return;
            _dbContext.Projects.Remove(
                _dbContext.Projects.First(p => p.Id == id));
            _dbContext.Appointments.RemoveRange(
                _dbContext.Appointments.Where(a => a.Project.Id == id));
            _dbContext.SaveChanges();
        }
    }
}