using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SHeDSchedule.Models
{
    public class Staff
    {
        [Key]
        public int staffId { get; set; }       
        public string initials { get; set; }
        public bool ATC { get; set; }
        public int term { get; set; }
    }
}
