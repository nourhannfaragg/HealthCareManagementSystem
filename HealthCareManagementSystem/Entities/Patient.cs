using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthCareManagementSystem.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
