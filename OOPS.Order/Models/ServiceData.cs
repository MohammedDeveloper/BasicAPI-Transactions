using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOPS.Order.Models
{
    /// <summary>
    /// Represnets the model for Order's Service
    /// </summary>
    public class ServiceData
    {
        /// <summary>
        /// Gets or sets the service Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the service name
        /// </summary>
        public string Name { get; set; }
    }
}