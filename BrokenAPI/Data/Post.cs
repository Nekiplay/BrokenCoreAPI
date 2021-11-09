namespace BrokenAPI.Data
{
    public class Post
    {
        public int attach_count { get; set; }
        public bool can_edit { get; set; }
        public bool can_hard_delete { get; set; }
        public bool can_react { get; set; }
        public bool can_soft_delete { get; set; }
        public bool can_view_attachments { get; set; }
        public bool is_first_post { get; set; }
        public bool is_last_post { get; set; }
        public bool is_reacted_to { get; set; }
        public bool is_unread { get; set; }
        public int last_edit_date { get; set; }
        public string message { get; set; }
        public string message_parsed { get; set; }
        public string message_state { get; set; }
        public int position { get; set; }
        public int post_date { get; set; }
        public int post_id { get; set; }
        public int reaction_score { get; set; }
        public int thread_id { get; set; }
        public User User { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string view_url { get; set; }
        public string warning_message { get; set; }
    }
}
