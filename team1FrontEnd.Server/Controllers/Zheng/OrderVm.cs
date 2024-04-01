namespace team1FrontEnd.Server.Controllers.Zheng
{
    public class OrderVm
    {
        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? LicenceId { get; set; }

        public string? CarBrand { get; set; }

        public string? CarModel { get; set; }

        public DateTime Begin { get; set; }

        public DateTime End { get; set; }

        public int? Total { get; set; }

        public string GetDesc()
        {
            var props = this.GetType().GetProperties();

            string result = string.Empty;

            foreach (var prop in props)
            {
                if (prop.GetValue(this) == null) { continue; }
                result += prop.Name + ":" + prop.GetValue(this).ToString();
            }

            return result;
        }
    }
}
