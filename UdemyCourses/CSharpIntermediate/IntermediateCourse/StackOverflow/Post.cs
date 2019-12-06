using System;

namespace StackOverflow
{
    public class Post
    {
        public string Title { get; set; }
        private string _description { get; set; }
        private DateTime _dateCreated { get; set; }
        private int _voteValue { get; set; }

        public Post(string title, DateTime dateCreated)
        {
            Title = title;
            _dateCreated = dateCreated;
        }

        public int GetVoteValue()
        {
            return _voteValue;
        }

        public void SetVoteValue(int value)
        {
            _voteValue = value;
        }

        public string AddDescription(string description)
        {
            _description = description;
            return _description;
        }

        public void UpVotePost()
        {
            _voteValue++;
        }

        public void DownVotePost()
        {
            _voteValue--;
        }
    }
}
