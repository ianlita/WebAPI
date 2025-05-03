using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifetimeServiceController : ControllerBase
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;

        public LifetimeServiceController(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var scopedServiceMessage = _scopedService.SayHello();
            var transientServiceMessage = _transientService.SayHello();
            var singletonServiceMessage = _singletonService.SayHello();
            
            return Content(
                $"{scopedServiceMessage}{Environment.NewLine}{transientServiceMessage}{Environment.NewLine}{ singletonServiceMessage}"
            );
    }
    }
}