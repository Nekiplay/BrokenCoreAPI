namespace BrokenAPI.Data
{
    public class Question
    {
        public bool allow_answer_voting { get; set; }
        public bool allow_downvote { get; set; }
        public int solution_post_id { get; set; }
        public int solution_user_id { get; set; }
        public string allow_question_actions { get; set; }
    }
}
