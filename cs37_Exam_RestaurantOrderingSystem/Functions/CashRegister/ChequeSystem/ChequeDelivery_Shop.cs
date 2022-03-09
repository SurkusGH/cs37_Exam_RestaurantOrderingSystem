using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem
{
    internal class ChequeAutoDelivery_Shop : ISendCheque
    {
        public static void SendCheque()
        {
            // Mime stands for Multiple Internet Mail Extensions
            // Tools -> Nuget Package Manager -> Package manager console: pm> Install-Package MailKit
            // Less secure app access (G Account security settings)
            MimeMessage message = new MimeMessage(); // <-- Sukuriu naują message objektą, į kurį talpinsiu datą laiško
            message.From.Add(new MailboxAddress("C# Vidinis-Čekis", "DotNetSendingEmail@gmail.com")); // <-- šitą dalį gavėjas matys kaip sender lauką

            message.To.Add(MailboxAddress.Parse("V.Surkus@me.com")); // <-- Adresato laukas; parse konvertuoja string'ą į pašto adreso duomenį
            message.To.Add(MailboxAddress.Parse("DotNetSendingEmail@gmail.com"));

            message.Subject = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} Pirkinys";

            ChequeGenerator.ChequeConstructor_Shop();

            message.Body = new TextPart("plain")
            {
                Text = ChequeGenerator.InternalCheque
            };

            #region (!) SENSITIVE DATA
            //Console.Write("Email: ");
            string emailAdress = "DotNetSendingEmail@gmail.com";
            //Console.Write("Password: ");
            string password = "qio-778-211";
            #endregion

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true); // 465 port'as. bool klausia ar naudojamas SSL
                client.Authenticate(emailAdress, password); // <-- autentikacija
                client.Send(message); // <-- nurodymas siųsti
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true); // <-- atsijungiama
                client.Dispose();        // <-- trinamas objektas
            }
        }
    }
}
