using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;

namespace PROG7311_TASK2.ViewModel
{
    public class PaymentMethodViewModel:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Processor { get; set; }
    }

    public class PaymentMethodListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Processor { get; set; }
        public int TotalOrders { get; set; }
    }
}
