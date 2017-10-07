using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = string.Empty;
            var smtp = new SmtpClient();

            while (true)
            {
                Console.WriteLine("Enter an email address to send a test msg:");

                email = Console.ReadLine();

                if (email.Contains('@'))
                {
                    try
                    {
                        smtp.Send(new MailMessage("test@emailtester.com", email, "Test", "Test works!"));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    break;
                }

            }
        }
    }
}
