using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpMgmt.API
{
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        public const string _defaultServerErrorMessage = "Server Error";

        internal readonly T _service;

        public BaseController(T service)
        {
            _service = service;
        }
    }
}

