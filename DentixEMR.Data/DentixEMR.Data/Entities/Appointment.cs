using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Missed,
        Cancelled
    }

    public class Appointment
    {
       public int AppointmentId { get; set; } 

       public int PatientId { get; set; }

       public int DentistId { get; set; }

       public DateTime AppointmentDate { get; set; }

       public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;

       public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties

        public Patient Patient { get; set; } = null!;

        public User Dentist { get; set; } = null!;

        public Visit? Visit { get; set; }

    }
}
