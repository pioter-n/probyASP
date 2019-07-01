using System.Collections.Generic;

namespace WebApplication2.Domain
{
    public class User : Entity
    {
        public string UserName { get; protected set; }
        public string PasswordHash { get; protected set; }

        public ICollection<Todo> Todos { get; protected set; } = new List<Todo>();
        public User(string userName, string passwordHash)
        {
            UserName = userName;
            PasswordHash = passwordHash;
        }
    }
}