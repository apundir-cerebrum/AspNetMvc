using Laoshi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laoshi.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IServiceFactory ServiceFactory;


        public BaseController(IServiceFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;

        }
    }
}
