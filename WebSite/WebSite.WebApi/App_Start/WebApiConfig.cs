﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebSite.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            config.MapHttpAttributeRoutes();
        }
    }
}
