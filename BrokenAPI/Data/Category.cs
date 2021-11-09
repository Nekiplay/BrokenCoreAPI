namespace BrokenAPI.Data
{
    public class Category
    {
        public bool allow_commercial_external { get; set; }
        public bool allow_external { get; set; }
        public bool allow_fileless { get; set; }
        public bool allow_local { get; set; }
        public bool can_add { get; set; }
        public bool can_upload_images { get; set; }
        public string description { get; set; }
        public int display_order { get; set; }
        public bool enable_support_url { get; set; }
        public bool enable_versioning { get; set; }
        public int last_resource_id { get; set; }
        public string last_resource_title { get; set; }
        public int last_update { get; set; }
        public int min_tags { get; set; }
        public int parent_category_id { get; set; }
        public int resource_category_id { get; set; }
        public int resource_count { get; set; }
        public string title { get; set; }
        public string view_url { get; set; }
    }
}
