using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace MalamProject
{
    public class Program
    {

        static void Main(string[] args)
        {

            MailClass mailClass = new MailClass();
            Console.WriteLine("Enter your Email:");
            string email = Console.ReadLine();
            if (email.IsValidEmail() == false)
            {
                Console.WriteLine("This Email Not Valid");
                Console.ReadKey();

                return;
            }

            else
            {
                Console.WriteLine("The Email Address is: " + email);
                Console.WriteLine("Enter Subject:");
                string subject = Console.ReadLine();
                if ( subject == "")
                {
                    Console.WriteLine("This Field can't be NULL");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("The Email subject is: " + subject);
                    Console.WriteLine("Enter Body:");
                    string body = Console.ReadLine();
                    if (body == "")
                    {
                        body = " ";
                    }
                    Console.WriteLine("The Email body is: " + body);

                    Console.WriteLine(mailClass.sendEEmail(email, subject, body));
                }
            }
            string path = "C:/MalamProject/json1.json";
            LoadFileClass loadFileClass = new LoadFileClass();
            loadFileClass.loadFile(path);
            Console.ReadKey();
        }
    }
}
