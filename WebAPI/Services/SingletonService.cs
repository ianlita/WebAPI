using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid _serviceId;
        private readonly DateTime _createdAt;
        public SingletonService()
        {
            _serviceId = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public string Name() => nameof(SingletonService);

        public string SayHello() => $"Hello from {Name} with ID: {_serviceId} created at {_createdAt}";
    }
}