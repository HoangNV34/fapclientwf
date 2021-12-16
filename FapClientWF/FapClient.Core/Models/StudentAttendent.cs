using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FapClient.Core.Models
{
    public class StudentAttendent
    {
        public int RollCallBookId { get; set; }

        public int? TeachingScheduleId { get; set; }

        public int StudentId { get; set; }

        public int? Slot { get; set; }

        public int? RoomId { get; set; }

        public int InstructorId { get; set; }

        public DateTime? TeachingDate { get; set; }

        public bool? IsAbsent { get; set; }

        public string Comment { get; set; }
    }
}
