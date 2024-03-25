namespace team1FrontEnd.Server.Dto
{
    public class HotelFacilitiesDto
    {
        public int Id { get; set; }
        public string JAON { get; set; }

        // 假设这是一个解析JSON的属性
        //public IEnumerable<Facility> Facilities
        //{
        //    get
        //    {
        //        // 这里应该是将Json字符串解析成Facility对象的列表
        //        // 以下代码是示意性的，您需要根据实际的JSON结构来解析
        //        //return JsonConvert.DeserializeObject<List<Facility>>(JAON);
        //    }
        //}
    }

    public class Facility
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }


}
