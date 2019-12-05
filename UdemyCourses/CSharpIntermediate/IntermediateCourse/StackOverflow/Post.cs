using System;

namespace StackOverflow
{
    public class Post
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _dateCreated { get; set; }
        protected int VoteValue { get; set; }


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
