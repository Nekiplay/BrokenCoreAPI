namespace BrokenAPI.Data
{
    public class TypeData
    {
        public bool allow_posting { get; set; }
        public bool can_create_thread { get; set; }
        public bool can_upload_attachment { get; set; }
        public Discussion discussion { get; set; }
        public int discussion_count { get; set; }
        public string forum_type_id { get; set; }
        public bool is_unread { get; set; }
        public int last_post_date { get; set; }
        public int last_post_id { get; set; }
        public string last_post_username { get; set; }
        public int last_thread_id { get; set; }
        public int last_thread_prefix_id { get; set; }
        public string last_thread_title { get; set; }
        public int message_count { get; set; }
        public int min_tags { get; set; }
        public bool require_prefix { get; set; }
        public Question question { get; set; }
        public Article article { get; set; }
    }

}
