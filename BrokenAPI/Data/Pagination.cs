namespace BrokenAPI.Data
{
    public class Pagination
    {
        public int current_page { get; set; }
        public int last_page { get; set; }
        public int per_page { get; set; }
        public int shown { get; set; }
        public int total { get; set; }
    }
}
