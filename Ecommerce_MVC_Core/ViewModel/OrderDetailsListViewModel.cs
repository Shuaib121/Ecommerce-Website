using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;

namespace PROG7311_TASK2.ViewModel
{
    public class OrderDetailsListViewModel:BaseEntity
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }

        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public string Remarks { get; set; }
    }
}
