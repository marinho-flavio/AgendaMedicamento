using SES.CrossCutting.Infra.Log.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SES.Core.Application.Aggregates.Common
{
    public class BaseController : ControllerBase
    {
        protected readonly ILogRequestContext _logRequestContext;
        public BaseController(ILogRequestContext logRequestContext)
        {
            _logRequestContext = logRequestContext;
        }
        
    }
}
