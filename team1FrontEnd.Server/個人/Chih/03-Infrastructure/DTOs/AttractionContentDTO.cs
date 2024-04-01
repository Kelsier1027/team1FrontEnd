namespace myapi._03_Infrastructure.DTOs
{
    public class AttractionContentDTO
    {
        public int AttractionId { get; set; }   
        public string AttractionName { get; set; }  
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public decimal LowPrice { get; set; }

        public List<AttractionContentImageDTO> AttractionContentImageDTO {  get; set; }
        public List<AttractionContentContextDTO> AttractionContentContextDTO { get; set; }


    }
}
