using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;

namespace PROG7311_TASK2.ViewModel
{
    public class StatusViewModel:BaseEntity
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
    }
}
