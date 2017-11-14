using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalEmails=new Dictionary<string, string>();
            var name = Console.ReadLine();
            if (name == "stop")
                return;
                
          
            do
            {
                var email = Console.ReadLine();
                var charEmail = email.ToList();
                var lastChar = email[charEmail.Count - 1];
                var halfPastChar = email[charEmail.Count - 2];
                if (halfPastChar == 'u' && lastChar == 's' || halfPastChar == 'u' && lastChar == 'k')
                {

                }
                else
                {
                    personalEmails[name] = email;
                }

                name = Console.ReadLine();
                
            } while (name != "stop");

            foreach (var person in personalEmails)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
