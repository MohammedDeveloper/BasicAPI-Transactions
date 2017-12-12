using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OOPS.Order.Controllers
{
    using OOPS.Order.Services;
    using OOPS.Order.Models;

    /// <summary>
    /// Represents the Order API Controller
    /// </summary>
    public class OrderController : ApiController
    {
        /// <summary>
        /// Represents the order service
        /// </summary>
        private IOrderService _orderService;

        public OrderController()
        {
            /// Set the object
            this._orderService = new OrderService();
        }

        /// <summary>
        /// Represents the API to query orders information
        /// </summary>
        /// <returns>
        /// Orders data
        /// </returns>
        [ActionName("GetOrders")]
        public HttpResponseMessage GetOrders()
        {
            try
            {
                /// Query the orders...
                List<OrderData> listOfOrders = this._orderService.GetOrders();

                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = string.Empty,
                    status = HttpStatusCode.OK,
                    orders = listOfOrders
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /// <summary>
        /// Represents the API to add service to the order
        /// </summary>
        [HttpPost]
        [ActionName("AddService")]
        public HttpResponseMessage PostAddService(int orderId)
        {
            try
            {               
                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = "Service added to the order - " + orderId,
                    status = HttpStatusCode.OK
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /// <summary>
        /// Represents the API to cancel order
        /// </summary>
        [HttpPost]
        [ActionName("CancelOrder")]
        public HttpResponseMessage PostCancelOrder(int orderId)
        {
            try
            {
                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = "Order Id " + orderId + " cancellation is successful!",
                    status = HttpStatusCode.OK
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /// <summary>
        /// Represents the API to handle order billing
        /// </summary>
        [HttpPost]
        [ActionName("Billing")]
        public HttpResponseMessage PostOrderBilling(int orderId)
        {
            try
            {
                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = "Order Id " + orderId + " billing is successful!",
                    status = HttpStatusCode.OK
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
