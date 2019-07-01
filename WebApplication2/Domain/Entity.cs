using System;

namespace WebApplication2.Domain
{
    public abstract class Entity
    {
        public string Id { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}