using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AndreyTest.Models
{
    public class Worker
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public List<Appointment> Projects { get; set; }
    }
}