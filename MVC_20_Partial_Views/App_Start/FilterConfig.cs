﻿using System.Web;
using System.Web.Mvc;

namespace MVC_20_Partial_Views
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
