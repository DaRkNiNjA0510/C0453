using System;

namespace ConsoleAppProject.App04
{
    public class MessagePost : Post
    {
        public string Message { get; }

        public MessagePost(string author, string message) : base(author)
        {
            this.Message = message;
        }

        public override void Display()
        {
            Console.WriteLine($"Message Post ID: {PostId}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Message: {Message}");
        }
    }
}
