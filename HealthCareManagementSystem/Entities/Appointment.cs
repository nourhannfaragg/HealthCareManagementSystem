using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthCareManagementSystem.Entities
{
    public class Appointment
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        [Required]
        public Patient Patient { get; set; }
        [Required]
        public Doctor Doctor { get; set; }
    }
}
