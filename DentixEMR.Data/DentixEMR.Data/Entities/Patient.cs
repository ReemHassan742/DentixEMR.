using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FullName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = null!;
        
        public string PhoneNumber { get; set; } = null!;

        public string? Email { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string? Occupation { get; set; }

        public string? EmergencyContact { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public MedicalRecord? MedicalRecord { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();

        public ICollection<Alert> Alerts { get; set; } = new List<Alert>();

        public ICollection<Document> Documents { get; set; } = new List<Document>();


    }
}
