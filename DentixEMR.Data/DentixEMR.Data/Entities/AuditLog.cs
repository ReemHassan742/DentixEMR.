using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }

        public int UserId { get; set; }

        public string Action { get; set; } = null!;

        // --> Name of affected entity (Patient, Appointment, etc.)
        public string EntityName { get; set; } = null!;

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public User User { get; set; } = null!;
    }
}
