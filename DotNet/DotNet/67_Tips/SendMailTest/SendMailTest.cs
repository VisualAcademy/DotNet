using System.Net;
using System.Net.Mail;

class SendMailTest
{
    static void Main()
    {
        SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
        var mail = new MailMessage();
        // [1] 보내는 이메일 넣는 곳
        mail.From = new MailAddress("youremail@yourdomain");
        // [2] 받는 이메일 넣는 곳
        mail.To.Add("youremail@yourdomain"); 
        mail.Subject = "메일 보내기 테스트";
        mail.IsBodyHtml = true;
        string htmlBody;
        htmlBody = "안녕하세요. <em>아웃룩</em> 메일 보내기 테스트입니다.";
        mail.Body = htmlBody;
        SmtpServer.Port = 587;
        SmtpServer.UseDefaultCredentials = false;
        // [3] outlook.com 이메일 계정 정보
        SmtpServer.Credentials = 
            new NetworkCredential("youremail@yourdomain", "password"); 
        SmtpServer.EnableSsl = true;
        SmtpServer.Send(mail);
    }
}
