using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHeDSchedule.Models.ViewModels
{
    public class StaffViewModel
    {
        public IEnumerable<Staff> staff { get; set; }
        public Monday monday { get; set; }
        public Tuesday tuesday { get; set; }
        public Wednesday wednesday { get; set; }
        public Thursday thursday { get; set; }
        public Friday friday { get; set; }
    }
}
