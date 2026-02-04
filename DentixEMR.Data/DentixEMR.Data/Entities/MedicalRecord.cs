using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public class MedicalRecord
    {
        public int MedicalRecordId { get; set; }

        public int PatientId { get; set; }

        public string? Allergies { get; set; }

        public string? Medications { get; set; }

        public string? PreviousSurgeries { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        // Navigation properties

        public Patient Patient { get; set; } = null!;
    }
}
