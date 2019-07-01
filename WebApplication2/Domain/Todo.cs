namespace WebApplication2.Domain
{
    public class Todo : Entity
    {
        public string Description { get; protected set; }

        public Todo(string description)
        {
            Description = description;
        }
    }
}