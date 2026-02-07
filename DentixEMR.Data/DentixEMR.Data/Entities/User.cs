using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public enum UserRole
    {
        Dentist,
        Assistant,
        Admin
    }
    public class User
    {
        public int UserId { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public UserRole Role { get; set; } 


        public bool IsActive { get; set; } = true; 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties 
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
