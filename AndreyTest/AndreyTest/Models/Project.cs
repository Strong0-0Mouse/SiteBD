using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AndreyTest.Models
{
    public class Project
    {
        [Key] public int Id { get; set; }
        public string NameProject { get; set; }
        public string NameCustomerCompany { get; set; }
        public string NamePerformingCompany { get; set; }
        public Worker Leader { get; set; }
        public List<Appointment> Performers { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Priority { get; set; }
    }
}