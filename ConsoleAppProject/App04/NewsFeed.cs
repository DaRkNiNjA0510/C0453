﻿using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Jake";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "I'm Learning C# Coding");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "C# Coding.png", "C# Coding in Visual Studio 2019");
            AddPhotoPost(photoPost);
        }

        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param message  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        ///<summary>
        /// Remove a post from the news feed.
        /// 
        /// @param id  The ID of the post to be removed.
        ///</summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);

            if (post == null)
            {
                Console.WriteLine($"\nPost with ID = {id} does not exist!!\n");
            }
            else
            {
                Console.WriteLine($"\nThe following post {id} has been removed!\n");

                if (post is MessagePost mp)
                {
                    mp.Display();
                }
                else if (post is PhotoPost pp)
                {
                    pp.Display();
                }
                posts.Remove(post);
            }
        }

        ///<summary>
        /// Find a post by its ID.
        /// 
        /// @param id  The ID of the post to be found.
        /// @return  The post with the specified ID, or null if no such post exists.
        ///</summary>
        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostId == id)
                {
                    return post;
                }
            }
            return null;
        }
    }
}
