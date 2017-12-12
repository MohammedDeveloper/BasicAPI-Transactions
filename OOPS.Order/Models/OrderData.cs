using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPS.Order.Models
{
    /// <summary>
    /// Represnets the model for Order
    /// </summary>
    public class OrderData
    {
        /// <summary>
        /// Constructor to initialize props
        /// </summary>
        public OrderData()
        {
            /// set the defaults
            this.Services = new List<ServiceData>();
        }

        /// <summary>
        /// Gets or sets the order Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the Account Number
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the order's Services
        /// </summary>
        public ICollection<ServiceData> Services { get; set; }
    }
}