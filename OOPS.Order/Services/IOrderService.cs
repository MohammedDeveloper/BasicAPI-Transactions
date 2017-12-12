using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPS.Order.Services
{
    using OOPS.Order.Models;

    /// <summary>
    /// Interface to hold the order's transactions
    /// </summary>
    public interface IOrderService
    {       
        /// <summary>
        /// Gets the orders info
        /// </summary>
        List<OrderData> GetOrders();
    }
}