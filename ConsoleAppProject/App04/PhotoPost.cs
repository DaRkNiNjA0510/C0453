using System;

namespace ConsoleAppProject.App04
{
    public class PhotoPost : Post
    {
        public string Filename { get; }
        public string Caption { get; }

        public PhotoPost(string author, string filename, string caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }

        public override void Display()
        {
            Console.WriteLine($"Photo Post ID: {PostId}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Filename: {Filename}");
            Console.WriteLine($"Caption: {Caption}");
        }
    }
}
