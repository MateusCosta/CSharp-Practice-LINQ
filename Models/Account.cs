using System.Threading;

namespace linq_practice.Models
{
    public class Account
    {
          static int nextId;
        public int Number { get; private set; }
        public int UserId { get; private set; }
        public double Balance { get; private set; }

        public Account(int userId, double initialBalance){
            Number = Interlocked.Increment(ref nextId);
            UserId = userId;
            Balance = initialBalance;
        }
    }

    
}