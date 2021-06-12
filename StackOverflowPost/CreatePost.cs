using System;

namespace OOP_With_CSharp
{
    public class CreatePost
    {
        private Post Post;
        private readonly Vote Vote;

        public CreatePost()
        {
            Post = new Post();
            Vote = new Vote();
        }
        private string NewTitle()
        {
            Console.WriteLine("Title\nBe specific and imagine you’re asking a question to another person: ");
            var input = Console.ReadLine();

            Post.Title = input;
            return Post.Title;
        }
        private string NewDescription()
        {
            Console.WriteLine("\nBody\nInclude all the information someone would need to answer your question: ");
            var input = Console.ReadLine();

            Post.Description = input;
            return Post.Description;
        }

        private DateTime CreatedAt()
        {
            return DateTime.Now;
        }

        private Tuple<int, int> CastVote(string vote)
        {
            var downVotes = Vote.UpCount;
            var upVotes = Vote.DownCount;


            if (vote == "Down") Vote.DownVote();

            if (vote == "Up") Vote.UpVote();

            return Tuple.Create(downVotes, upVotes);
        }


        public void App()
        {
            var title = NewTitle();
            var description = NewDescription();
            var created = CreatedAt();
            var votes = CastVote("");

            while (true)
            {
                System.Console.WriteLine("\n{0}\n{1}\n{2}\nUp votes: {3}\nDown votes: {4}", title, created, description, votes.Item1, votes.Item2);

                Console.WriteLine("Enter 'Down' to cast a Down Vote, and 'Up' to cast a Up Vote on this post: ");
                var input = Console.ReadLine();

                votes = CastVote(input);
            }
        }
    }
}