using System.Threading;

namespace linq_practice.Models
{
    public class User
    {
        static int nextId;
        public int UserId { get; private set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public User(string email, string name){
            UserId = Interlocked.Increment(ref nextId);
            Email = email;
            Name = name;
        }

    }
}