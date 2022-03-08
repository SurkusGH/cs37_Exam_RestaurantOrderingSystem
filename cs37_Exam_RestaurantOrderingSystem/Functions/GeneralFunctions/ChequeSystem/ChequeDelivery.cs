//using System;
//using MimeKit;
//using MailKit.Net.Smtp;

//namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem
//{
//    public class ChequeDelivery
//    {
//        public static void SendCheque()
//        {
//            // Mime stands for Multiple Internet Mail Extensions
//            // Tools -> Nuget Package Manager -> Package manager console: pm> Install-Package MailKit
//            // Less secure app access (G Account security settings)
//            MimeMessage message = new MimeMessage(); // <-- Sukuriu naują message objektą, į kurį talpinsiu datą laiško
//            message.From.Add(new MailboxAddress("C# Čekis", "DotNetSendingEmail@gmail.com")); // <-- šitą dalį gavėjas matys kaip sender lauką

//            message.To.Add(MailboxAddress.Parse("V.Surkus@me.com")); // <-- Adresato laukas; parse konvertuoja string'ą į pašto adreso duomenį
//            message.To.Add(MailboxAddress.Parse("DotNetSendingEmail@gmail.com"));

//            message.Subject = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} Pirkinys";

//            CartAndChequeSystem.ConstructChequeString();

//            message.Body = new TextPart("plain")
//            {
//                //Text = "Testas"
//                Text = ExternalCheque.Cheque
//            };
//            #region (!) SENSITIVE DATA
//            //Console.Write("Email: ");
//            string emailAdress = "DotNetSendingEmail@gmail.com";
//            //Console.Write("Password: ");
//            string password = "qio-778-211";
//            #endregion

//            SmtpClient client = new SmtpClient();

//            try
//            {
//                client.Connect("smtp.gmail.com", 465, true); // 465 port'as. bool klausia ar naudojamas SSL
//                client.Authenticate(emailAdress, password); // <-- autentikacija
//                client.Send(message); // <-- nurodymas siųsti
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                client.Disconnect(true); // <-- atsijungiama
//                client.Dispose();        // <-- trinamas objektas
//            }
//        }
//    }
//}

