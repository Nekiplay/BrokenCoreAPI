using System.Collections.Generic;

namespace BrokenAPI.Data
{
    public class Thread
    {
        public bool can_edit { get; set; }
        public bool can_edit_tags { get; set; }
        public bool can_hard_delete { get; set; }
        public bool can_reply { get; set; }
        public bool can_soft_delete { get; set; }
        public bool can_view_attachments { get; set; }
        public CustomFields custom_fields { get; set; }
        public bool discussion_open { get; set; }
        public string discussion_state { get; set; }
        public string discussion_type { get; set; }
        public int first_post_id { get; set; }
        public int first_post_reaction_score { get; set; }
        public Forum Forum { get; set; }
        public List<object> highlighted_post_ids { get; set; }
        public bool is_first_post_pinned { get; set; }
        public bool is_unread { get; set; }
        public bool is_watching { get; set; }
        public int last_post_date { get; set; }
        public int last_post_id { get; set; }
        public int last_post_user_id { get; set; }
        public string last_post_username { get; set; }
        public int node_id { get; set; }
        public int post_date { get; set; }
        public string prefix { get; set; }
        public int prefix_id { get; set; }
        public int reply_count { get; set; }
        public bool sticky { get; set; }
        public List<string> tags { get; set; }
        public int thread_id { get; set; }
        public string title { get; set; }
        public User User { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public int view_count { get; set; }
        public string view_url { get; set; }
        public int visitor_post_count { get; set; }
        public Question question { get; set; }
    }
}
