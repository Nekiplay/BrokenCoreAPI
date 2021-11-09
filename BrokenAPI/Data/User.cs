namespace BrokenAPI.Data
{
    public class User
    {
        public bool activity_visible { get; set; }
        public AvatarUrls avatar_urls { get; set; }
        public bool can_ban { get; set; }
        public bool can_converse { get; set; }
        public bool can_edit { get; set; }
        public bool can_follow { get; set; }
        public bool can_ignore { get; set; }
        public bool can_post_profile { get; set; }
        public bool can_view_profile { get; set; }
        public bool can_view_profile_posts { get; set; }
        public bool can_warn { get; set; }
        public CustomFields custom_fields { get; set; }
        public string custom_title { get; set; }
        public bool is_admin { get; set; }
        public bool is_banned { get; set; }
        public bool is_followed { get; set; }
        public bool is_ignored { get; set; }
        public bool is_moderator { get; set; }
        public bool is_staff { get; set; }
        public bool is_super_admin { get; set; }
        public int last_activity { get; set; }
        public string location { get; set; }
        public int message_count { get; set; }
        public ProfileBannerUrls profile_banner_urls { get; set; }
        public int question_solution_count { get; set; }
        public int reaction_score { get; set; }
        public int register_date { get; set; }
        public string signature { get; set; }
        public int trophy_points { get; set; }
        public int user_id { get; set; }
        public string user_title { get; set; }
        public string username { get; set; }
        public string view_url { get; set; }
        public bool visible { get; set; }
        public int vote_score { get; set; }
        public int warning_points { get; set; }
        public string website { get; set; }
    }

}
