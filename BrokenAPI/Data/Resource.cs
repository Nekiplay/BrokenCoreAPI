using System.Collections.Generic;

namespace BrokenAPI.Data
{
    public class Resource
    {
        public string alt_support_url { get; set; }
        public bool can_download { get; set; }
        public bool can_edit { get; set; }
        public bool can_edit_icon { get; set; }
        public bool can_edit_tags { get; set; }
        public bool can_hard_delete { get; set; }
        public bool can_soft_delete { get; set; }
        public bool can_view_description_attachments { get; set; }
        public Category Category { get; set; }
        public string currency { get; set; }
        public List<CurrentFile> current_files { get; set; }
        public CustomFields custom_fields { get; set; }
        public string description { get; set; }
        public int description_attach_count { get; set; }
        public string description_parsed { get; set; }
        public List<DescriptionAttachment> DescriptionAttachments { get; set; }
        public int download_count { get; set; }
        public string external_url { get; set; }
        public object icon_url { get; set; }
        public bool is_watching { get; set; }
        public int last_update { get; set; }
        public string prefix { get; set; }
        public int prefix_id { get; set; }
        public string price { get; set; }
        public int rating_avg { get; set; }
        public int rating_count { get; set; }
        public int rating_weighted { get; set; }
        public int reaction_score { get; set; }
        public int resource_category_id { get; set; }
        public int resource_date { get; set; }
        public int resource_id { get; set; }
        public string resource_state { get; set; }
        public string resource_type { get; set; }
        public int review_count { get; set; }
        public string tag_line { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }
        public int update_count { get; set; }
        public User User { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string version { get; set; }
        public int view_count { get; set; }
        public string view_url { get; set; }
    }
}
