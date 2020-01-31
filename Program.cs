using System;
using System.Linq;
using System.Collections.Generic;
using linq_practice.Models;
using Newtonsoft.Json;
namespace linq_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,0,12,34,567,123,345,445,57,12,90,78,6,54,4,58,44,4,64,6,46,464,4,4,};

            //Lambda syntax
            List<int> evens = numbers.Where(number => number%2 == 0).OrderBy(number => number).Select(number => number).ToList();
            
            //verbose syntax
            List<int> odds = (from number in numbers where number%2!=0 orderby number select number).ToList(); 

            //Pair
            Console.WriteLine("Evens");
            foreach(var number in evens)
                Console.WriteLine(number);
            
            //Odds
            Console.WriteLine("Odds");
            foreach(var number in odds)
                Console.WriteLine(number);

            //Linq with Objects
            var users = new List<User>();
            users.Add( new User("mateus@gmail.com", "Mateus"));
            users.Add( new User("maria@hotmail.com", "Maria"));
            users.Add( new User("paulo@live.com", "Paulo"));
            users.Add( new User("flavia@email.com", "Flávia"));
            users.Add( new User("gabi@bol.com.br", "Gabriela"));

            var gmailUsers = users.Where(user => user.Email.Contains("gmail.com")).ToList();

            foreach(var user in users)
                Console.WriteLine(String.Format("UserID: {0}, E-mail: {1}, Name: {2}", user.UserId, user.Email, user.Name));
            

            var bankAccounts = new List<Account>();
            bankAccounts.Add(new Account(1,0));
            bankAccounts.Add(new Account(1,500));
            bankAccounts.Add(new Account(2,245));
            bankAccounts.Add(new Account(3,684));
            bankAccounts.Add(new Account(4,988));
          
            var linkAccounts = from account in bankAccounts join owner in users on account.UserId equals owner.UserId
             select new {account, owner} ;

            foreach(var account in linkAccounts)
                Console.WriteLine(JsonConvert.SerializeObject(account));

            int[] numbers2 = {1,1,1,1,2,2,2,2,3,3,3,3,4,4,4,7,7,7,7,8,8,8,8,9,6,6,6,6,6,6,6,6,0,0,0,0};

            var orderedNumbers = numbers2.GroupBy(x => x).Select(x =>x);

             Console.WriteLine("Group By");
            foreach(var x in orderedNumbers)
                Console.WriteLine(x.Key);
            


        }
    }
}
