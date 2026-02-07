using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentixEMR.Data.Entities
{
    public class Document
    {
        public int DocumentId { get; set; }
        
        public int PatientId { get; set; }

        public int? VisitId { get; set; }

        public string FilePath { get; set; } = null!;

        public string FileType { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Patient Patient { get; set; } = null!;

        public Visit? Visit { get; set; }

    }
}
