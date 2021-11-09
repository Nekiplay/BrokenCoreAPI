using System.Collections.Generic;

namespace BrokenAPI.Data
{
    public class Forum
    {
        public List<Breadcrumb> breadcrumbs { get; set; }
        public string description { get; set; }
        public bool display_in_list { get; set; }
        public int display_order { get; set; }
        public int node_id { get; set; }
        public object node_name { get; set; }
        public string node_type_id { get; set; }
        public int parent_node_id { get; set; }
        public string title { get; set; }
        public TypeData type_data { get; set; }
        public string view_url { get; set; }
    }
}
