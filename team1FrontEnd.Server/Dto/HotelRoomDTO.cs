namespace team1FrontEnd.Server.Dto
{
    public class HotelRoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Facilities { get; set; } = new List<string>();
    }



}
