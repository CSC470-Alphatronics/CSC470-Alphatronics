using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;

namespace ClimbingWall
{
	class Email
    {
		static bool emailSent = false;

		public static void Mail(string[] args)
		{
			MailMessage message = new MailMessage();
			SmtpClient client = new SmtpClient();
			try
			{
				message.From = new MailAddress("climbingwall.sdstate@gmail.com", "SDSU Climbing Wall (Auto)");
				message.To.Add(new MailAddress("kenneth.grovenburg@jacks.sdstate.edu", "Kenneth Grovenburg"));  // Test for functionality
				message.CC.Add(new MailAddress("jack.holm@jacks.sdstate.edu", "Jack Holm"));
				message.Subject = "Email Test";
				message.Body = "This is a test of the emergency email alert system... and also the DB email system.";

				client.Host = "smtp.gmail.com";
				client.Port = 587;
				// Credentials = ("email of sender", "password of sender")
				client.Credentials = new System.Net.NetworkCredential("climbingwall.sdstate@gmail.com", "alphatronics17");
				client.EnableSsl = true;    // Runtime encrypt the SMTP communications using SSL
				client.Send(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}
		}
		
		
    }
}
