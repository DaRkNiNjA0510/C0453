using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Post
    {
        private int likes;

        private readonly List<String> comments;


        // username of the post's author
        public String Username { get; }

        // username of the post's author
        public DateTime TimeStamp { get; }


        /// <summary>
        /// 
        /// </summary>
        public Post(string author)
        {
            this.Username = author;
            TimeStamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }
        public void Like()
        {
            likes++;
        }
        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }
            ///<summary>
            /// Add a comment to this post.
            /// </summary>
            /// <param name="text">
            /// The new comment to add.
            /// </param>        
            public void AddComment(String text)
            {
                comments.Add(text);
            }
        //<summary>
        // Stopped video at 10:32am (C0453-05A Refactoring Using Inheritance)
        //</Summary>

    }
}
