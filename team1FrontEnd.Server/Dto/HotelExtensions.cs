// HotelExtensions.cs
using System.Text.Json;
using System.Linq;

namespace team1FrontEnd.Server.Models
{
    public partial class Hotel
    {
        // 這個方法用於從 JSON 字串中解析出設施 ID 列表
        public List<int> GetFacilityIds()
        {
            if (!string.IsNullOrEmpty(HotelFacilities))
            {
                try
                {
                    var facilityIdsObj = JsonSerializer.Deserialize<FacilityIdsObj>(HotelFacilities);
                    return facilityIdsObj?.FacilityIds ?? new List<int>();
                }
                catch (JsonException)
                {
                    // 如果 JSON 解析失敗，可以在這裡處理錯誤，例如記錄錯誤或返回空列表
                    return new List<int>();
                }
            }
            return new List<int>();
        }
    }

    // 這個類用於輔助 JSON 解析
    public class FacilityIdsObj
    {
        public List<int> FacilityIds { get; set; }
    }
}
