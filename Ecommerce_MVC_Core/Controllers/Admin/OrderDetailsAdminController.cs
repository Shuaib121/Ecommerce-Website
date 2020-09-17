using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROG7311_TASK2.Data;
using PROG7311_TASK2.Models;
using PROG7311_TASK2.Models.Admin;
using PROG7311_TASK2.Repository;
using PROG7311_TASK2.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PROG7311_TASK2.Controllers.Admin
{
    public class OrderDetailsAdminController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public OrderDetailsAdminController(
            IUnitOfWork unitOfWork
        )
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index( string search="")
        {
            var orderList = GetAllOrderDetails();
            if (!String.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                orderList = GetAllOrderDetails().Where(x =>
                    x.OrderNumber.ToLower().Contains(search) 
                ).ToList();
                ViewBag.SearchString = search;
            }

            return View(orderList);
        }


        public List<OrderDetailsListViewModel> GetAllOrderDetails()
        {
            List<OrderDetailsListViewModel> orderDetailsList = new List<OrderDetailsListViewModel>();
            _unitOfWork.Repository<OrderDetails>().GetAllInclude(x=>x.Orders,p=>p.Product).OrderByDescending(x=>x.AddedDate).ToList().ForEach(o =>
            {
                OrderDetailsListViewModel orderDetails = new OrderDetailsListViewModel
                {
                    Id = o.Id,
                    ModifiedDate = o.ModifiedDate,
                    AddedDate = o.AddedDate,
                    ProductId = o.ProductId,
                    OrderId = o.OrderId,
                    Quantity = o.Quantity,
                    Rate = o.Rate,
                    Remarks = o.Remarks,
                    OrderNumber = o.Orders.Number,
                    ProductName = o.Product.Name,
                };
                orderDetailsList.Add(orderDetails);
            });

            return orderDetailsList;
        }
    }
}