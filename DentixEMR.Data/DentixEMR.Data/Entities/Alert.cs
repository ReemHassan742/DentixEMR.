using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public enum AlertType
    {
        MissedAppointment,
        Reminder,
        CriticalCase
    }
    public class Alert
    {
        public int AlertId { get; set; }

        public int PatientId { get; set; }

        public AlertType Type { get; set; }

        public string Message { get; set; } = null!;

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public Patient Patient { get; set; } = null!;
    }
}
