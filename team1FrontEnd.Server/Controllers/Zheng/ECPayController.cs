using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace team1FrontEnd.Server.Controllers.Zheng
{
    [Route("api/[controller]")]
    [ApiController]
    public class ECPayController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Dictionary<string, string>> GetECPayOrder([FromBody]OrderVm vm)
        {
            Random rnd = new Random();

            var order = new Dictionary<string, string>
            {
                //綠界需要的參數
                { "MerchantTradeNo",  rnd.Next().ToString()},
                { "MerchantTradeDate",  DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")},
                { "TotalAmount",  vm.Total.ToString()},
                { "TradeDesc",  "abc"},
                { "ItemName",  "租車"},
                { "CustomField1",  vm.GetDesc()},
                { "ReturnURL",  "https://localhost:7113/api/ecpayorders"},
                { "OrderResultURL", "https://localhost:7113/api/ecpayorders"},
                { "MerchantID",  "3002607"},
                { "PaymentType",  "aio"},
                { "ChoosePayment",  "ALL"},
                { "EncryptType",  "1"},
            };
            //檢查碼
            order["CheckMacValue"] = GetCheckMacValue(order);
            return Ok(order);
        }
        private string GetCheckMacValue(Dictionary<string, string> order)
        {
            var param = order.Keys.OrderBy(x => x).Select(key => key + "=" + order[key]).ToList();
            var checkValue = string.Join("&", param);
            //測試用的 HashKey
            var hashKey = "pwFHCqoQZGmho4w6";
            //測試用的 HashIV
            var HashIV = "EkRm7iFT261dpevs";
            checkValue = $"HashKey={hashKey}" + "&" + checkValue + $"&HashIV={HashIV}";
            checkValue = HttpUtility.UrlEncode(checkValue).ToLower();
            checkValue = HashHelper.ToSHA256(checkValue);
            return checkValue.ToUpper();
        }
    }
    public static class HashHelper
    {
        public static string ToSHA256(string value)
        {
            using (var mySHA256 = SHA256.Create())
            {
                var bts = Encoding.UTF8.GetBytes(value);

                var hash = mySHA256.ComputeHash(bts);

                var result = new StringBuilder();

                foreach (var b in hash) result.Append(b.ToString("X2"));

                return result.ToString();
            }
        }
    }
}
