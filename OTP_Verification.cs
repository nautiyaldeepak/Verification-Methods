// One Time Password Generation & Sending Via Email
// Add Reference packages For SMTP Mail
using System;
using System.Net.Mail;
using System.Net;

namespace SMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            int code = SendEmail();
            verify(code);
            Console.ReadLine();
        }

        public static void verify(int code)
        {
            Console.WriteLine("Enter the OTP ");
            int UserCode = Convert.ToInt32(Console.ReadLine());
            if (UserCode == code)
                Console.WriteLine("Code Verified");
            else
                Console.WriteLine("Wrong Code");
        }

        public static int SendEmail()
        {


            /*
             * 
                SMTP Protocols are different for every mail service.
                The Protocols mentioned below are only for outlook.
                Look at the readme file & Resources section for more information.
            *
            */
            string smtpAddress = "smtp-mail.outlook.com";
            int portNumber = 587;

            Random random = new Random();
            int num = random.Next(100000, 999999);
            string numb = num.ToString();
            string otpA = numb.Substring(0, 3);
            string otpB = numb.Substring(3);


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the Reciever's Mail Id");
            string emailTo = Console.ReadLine();
            Console.WriteLine("Enter the Sender's Mail Id (Outlook Mail)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("If Mail Id other than outlook then check the Readme");
            Console.ForegroundColor = ConsoleColor.White;
            string emailFrom = Console.ReadLine();
            Console.WriteLine("Enter the Sender's Mail Id Password (Outlook Mail)");
            string password = Console.ReadLine();
            Console.WriteLine("Sneding otp to " + emailTo + " ........");
            string subject = "One Time Password";
            string body = otpA + " " + otpB;

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
    }
}
