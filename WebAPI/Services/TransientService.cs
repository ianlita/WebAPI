using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services
{
    public class TransientService : ITransientService
    {
        private readonly Guid _serviceId;
        private readonly DateTime _createdAt;

        public TransientService()
        {
            _serviceId = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public string Name() => nameof(TransientService);
        public string SayHello() => $"Hello from {Name} with ID: {_serviceId} created at {_createdAt}";

    }
}