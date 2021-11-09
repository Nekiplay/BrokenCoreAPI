using System.Collections.Generic;

namespace BrokenAPI.Data
{
    public class Discussion
    {
        public List<string> allowed_thread_types { get; set; }
        public bool allow_answer_voting { get; set; }
        public bool allow_answer_downvote { get; set; }
    }
}
