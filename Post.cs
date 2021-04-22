using System;

namespace PlayingWithCSharp
{
    public class Post
    {
        public readonly DateTime CreatedDate;
        public int Votes { get; private set; }

        private string _title;
        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException("Title");
        }
        private string _description;

        public string Description
        {
            get => _description;
            set => _description = value ?? throw new ArgumentNullException("Description");
        }

        public Post()
        {
            CreatedDate = DateTime.Now;
        }

        public void UpVote() => Votes += 1;

        public void DownVote()=> Votes -= 1;

    }
}