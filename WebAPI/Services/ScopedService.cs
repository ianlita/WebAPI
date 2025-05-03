using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebAPI.Services
{
    public class ScopedService : IScopedService
    {
        private readonly Guid _serviceId;
        private readonly DateTime _createdAt;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;

        public ScopedService(ITransientService transientService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _singletonService = singletonService;
            _serviceId = Guid.NewGuid();
            _createdAt = DateTime.Now;
        }

        public string Name() => nameof(ScopedService);   
        public string SayHello() 
        {
            var scopedServiceMessage = $"Hello from {Name()} with ID: {_serviceId} created at {_createdAt}";
            var transientServiceMessage = $"{_transientService.SayHello()}. I am from {Name()}";
            var singletonServiceMessage = $"{_singletonService.SayHello()}. I am from {Name()}";

            return $"{scopedServiceMessage}\n {transientServiceMessage}\n {singletonServiceMessage}\n";
        }
            
            
    }
}