using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using Microsoft.AspNetCore.Http;

namespace PROG7311_TASK2.ViewModel
{
    public class ProductMenualViewModel:BaseEntity
    {
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public IFormFile ProductFile { get; set; }
        [Display(Name = "Manual Name")]
        public string ManualName { get; set; }
    }
}
