using System.ComponentModel.DataAnnotations;

namespace AndreyTest.Models
{
    public class Appointment
    {
        [Key] public int Id { get; set; }
        public Project Project { get; set; }
        public Worker Worker { get; set; }
    }
}