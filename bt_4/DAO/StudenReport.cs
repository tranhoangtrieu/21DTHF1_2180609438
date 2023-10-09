using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt_4.DAO
{
    public class StudenReport
    {
        [StringLength(50)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        public double AverageScore { get; set; }

        public string FacultyName { get; set; }
    }
}
