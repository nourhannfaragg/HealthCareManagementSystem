using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthCareManagementSystem.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Specialization { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
