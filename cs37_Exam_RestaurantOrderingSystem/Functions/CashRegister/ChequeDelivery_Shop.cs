using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using MailKit.Net.Smtp;
using MimeKit;
using System;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem
{
    internal class ChequeAutoDelivery_Shop : ISendCheque
    {
        public static void SendCheque()
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("C# Vidinis-Čekis", "DotNetSendingEmail@gmail.com"));

            message.To.Add(MailboxAddress.Parse("V.Surkus@me.com"));
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
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate(emailAdress, password);
                client.Send(message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
