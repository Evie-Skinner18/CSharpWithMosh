using System;

namespace StackOverflow
{
    public class Post
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _dateCreated { get; set; }
        protected int VoteValue { get; set; }

        public Post(string title, DateTime dateCreated)
        {
            _title = title;
            _dateCreated = dateCreated;
        }

        public string AddDescription(string description)
        {
            _description = description;
            return _description;
        }

        public void UpVotePost()
        {
            VoteValue += VoteValue;
        }

        public void DownVotePost()
        {
            VoteValue -= VoteValue;
        }


    }
}
