using QRCoder;
using System.Security.Cryptography;
using System.Text;

namespace team1FrontEnd.Server.個人.Chih._03_Infrastructure.Utilities
{
    public class Qrcode
    {
        public static void CreateQrcode(string text, string filePath) 
        {
            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                //net6.0後 QRCode 似乎無法使用 --> 
                using(var qrCode = new PngByteQRCode(qrData))
                {
                    byte[] image = qrCode.GetGraphic(20);
                    File.WriteAllBytes(filePath, image);
                }
            }
        }

        public static string ComputeHash(string input)
        {
            var salt = "abc306787414!";
            var inputData = Encoding.UTF8.GetBytes(input+salt);
            using(var sha256 = SHA256.Create())
            {
                var hash = sha256.ComputeHash(inputData);
                return Convert.ToBase64String(hash); 
            }
        }
    }
}
