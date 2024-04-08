using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Text;

namespace team1FrontEnd.Server.個人.Yen.Core.Infra
{
    public class MemberEmailHelper
    {
        private string senderEmail = "hakutravel31@gmail.com"; // 寄件者
        public void SendForgetPasswordEmail(string url, string name, string email)
        {
            var subject = "[重設密碼通知]";
            var body = $@"Hi {name},
請點擊此連結 {url} 重設密碼, 以進行重設密碼, 如果您沒有提出申請, 請忽略本信, 謝謝";
            var from = senderEmail;
            var to = email;
            SendViaGoogle(from, to, subject, body, name);
        }

        public void SendConfirmRegisterEmail(string url, string name, string email)
        {
        }

        public virtual async void SendViaGoogle(string from, string to, string subject, string body, string name)
        {
            #region OAuth驗證
            try
            {

                const string GMailAccount = "hakutravel31@gmail.com"; // 信箱帳號

                var clientSecrets = new ClientSecrets
                {
                    ClientId = "841135279083-nq27lqpbsl2v4jae3b1j83v4kg158n3d.apps.googleusercontent.com",
                    ClientSecret = "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"
                };

                var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    DataStore = new FileDataStore("CredentialCacheFolder", false),
                    Scopes = new[] { "https://mail.google.com/" },
                    ClientSecrets = clientSecrets
                });

                var codeReceiver = new LocalServerCodeReceiver();
                var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

                var credential = await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None);

                if (credential.Token.IsExpired(Google.Apis.Util.SystemClock.Default))
                    await credential.RefreshTokenAsync(CancellationToken.None);

                var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);
                #endregion

                #region 信件內容
                var message = new MimeMessage();
                //寄件者名稱及信箱(信箱是測試帳號)
                message.From.Add(new MailboxAddress("Haku-Travel", "hakutravel31@gmail.com"));
                //收件者名稱，收件者信箱
                message.To.Add(new MailboxAddress(name, to));
                //信件標題
                message.Subject = $"{subject}";
                //信件內容
                message.Body = new TextPart("plain")
                {
                    // 將 body 設定為信件內容
                    Text = $"{body}"
                };
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587); // 587是Gmail的port
                    await client.AuthenticateAsync(oauth2); // 使用OAuth2驗證
                    await client.SendAsync(message); // 寄出信件
                    await client.DisconnectAsync(true); // 關閉連線
                }
            }
            catch (Exception ex)
            {

            }

            #endregion
        }

        private void CreateTextFile(string path, string from, string to, string subject, string body)
        {
            var fileName = $"{to.Replace("@", "_")} {DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
            // 文字檔案的完整路徑
            var fullPath = Path.Combine(path, fileName);
            // 檔案內容
            var contents = $@"from:{from}
							to:{to}
							subject:{subject}
							{body}";
            // 建立文字檔案, 採用UTF8編碼
            File.WriteAllText(fullPath, contents, Encoding.UTF8);
        }

        internal void SendConfirmRegisterMail(string url, string name, string email)
        {
            var subject = "[電子信箱驗證信]";
            var body = $@"Hi {name},
請點擊此連結 {url} 驗證電子信箱, 如果您沒有提出申請, 請忽略本信, 謝謝";

            var from = senderEmail;
            var to = email;

            SendViaGoogle(from, to, subject, body, name);
        }


    }
}
