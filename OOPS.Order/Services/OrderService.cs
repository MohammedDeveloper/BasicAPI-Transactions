using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPS.Order.Services
{
    using OOPS.Order.Models;

    /// <summary>
    /// Handler/Service to perform order's transactions
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// Gets the orders info
        /// </summary>
        public List<OrderData> GetOrders()
        {
            /// get the orders information
            List<OrderData> listOfOrders = new List<OrderData>();

            /// Add the requirement based orders...
            listOfOrders.Add(new OrderData()
            {
                Id = 100,
                CustomerName = "Test Customer 100",
                AccountNumber = "ACCNBR100",
                Services = new List<ServiceData>()
                {
                    new ServiceData() { Id = 1001, Name = "Service 100 - 1" },
                    new ServiceData() { Id = 1002, Name = "Service 100 - 2" },
                    new ServiceData() { Id = 1003, Name = "Service 100 - 3" },
                    new ServiceData() { Id = 1004, Name = "Service 100 - 4" }
                }
            });

            /// Add the requirement based orders...
            listOfOrders.Add(new OrderData()
            {
                Id = 101,
                CustomerName = "Test Customer 101",
                AccountNumber = "ACCNBR101",
                Services = new List<ServiceData>()
                {
                    new ServiceData() { Id = 1005, Name = "Service 101 - 1" },
                    new ServiceData() { Id = 1006, Name = "Service 101 - 2" }
                }
            });

            /// Add the requirement based orders...
            listOfOrders.Add(new OrderData()
            {
                Id = 102,
                CustomerName = "Test Customer 102",
                AccountNumber = "ACCNBR102",
                Services = new List<ServiceData>()
                {
                    new ServiceData() { Id = 1006, Name = "Service 102 - 1" },
                    new ServiceData() { Id = 1007, Name = "Service 102 - 2" },
                    new ServiceData() { Id = 1008, Name = "Service 102 - 3" }
                }
            });

            /// return orders..
            return listOfOrders;
        }
    }
}