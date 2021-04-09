
using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        private string filename;

        /// <summary>
        /// 
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading(" Hamood's News Feed");

            string[] choices = new string[]
            {
                "Post A Message", "Post An Image", "" +
                "Remove a Post", "Display All Posts", 
                "Display Post By Author", "Display Post By Date",
                "Add comments to Post", "Like/Unlike Post", 
                "Quit"

            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LikePosts()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddComment()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($" Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ",
              1, Post.GetNumberofPosts());
            news.RemovePost(id);
        }

        /// <summary>
        /// 
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// 
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");
            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your  image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }       

        /// <summary>
        /// 
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();            

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have just posted this message:");
            post.Display();

        }

        /// <summary>
        /// 
        /// </summary>
        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
