﻿using System.Web;
using System.Web.Mvc;

namespace OOPS.Order
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
