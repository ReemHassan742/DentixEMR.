using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public class Visit
    {
       public int VisitId { get; set; }

       public int PatientId { get; set; }

       public int? AppointmentId { get; set; }

       public DateTime VisitDate { get; set; }

        public string? Diagnosis { get; set; }

        public string? TreatmentProvided { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties

        public Patient Patient { get; set; } = null!;

        public Appointment? Appointment { get; set; }

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
