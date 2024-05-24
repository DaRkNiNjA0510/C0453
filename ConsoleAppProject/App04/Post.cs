using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    public abstract class Post
    {
        private static int postCount = 0;
        public int PostId { get; }
        public string Author { get; }

        public Post(string author)
        {
            this.Author = author;
            this.PostId = ++postCount;
        }

        public abstract void Display();

        public static int GetNumberOfPosts()
        {
            return postCount;
        }
    }
}
