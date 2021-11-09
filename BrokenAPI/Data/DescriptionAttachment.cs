namespace BrokenAPI.Data
{
    public class DescriptionAttachment
    {
        public int attach_date { get; set; }
        public int attachment_id { get; set; }
        public int content_id { get; set; }
        public string content_type { get; set; }
        public string direct_url { get; set; }
        public int file_size { get; set; }
        public string filename { get; set; }
        public int height { get; set; }
        public bool is_audio { get; set; }
        public bool is_video { get; set; }
        public string thumbnail_url { get; set; }
        public int view_count { get; set; }
        public int width { get; set; }
    }
}
