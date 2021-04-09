using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Hamood Jaffery
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        private string author;

        private readonly List<String> comments;

        private readonly int Likes;

        public string Filename;

        private string Caption;

        public new DateTime Timestamp { get; }

        public PhotoPost(string author, string filename, string caption)
        {
            Username = author;
            this.Filename = filename;
            this.Caption = caption;
            Timestamp = DateTime.Now;

            Likes = 0;
            comments = new List<String>();
        }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Filename: {Filename}");
            Console.WriteLine($"    Caption: {Caption}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (Likes > 0)
            {
                Console.WriteLine($"    Likes:  {Likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s). Click here to view.");
            }
        }

        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }

        }
    }
}
