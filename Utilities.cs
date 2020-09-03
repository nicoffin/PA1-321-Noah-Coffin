using System;
using System.Collections.Generic;

namespace pa1_321
{
    public class Utilities
    {
        public static void AddPost(List<Post> allPosts)
        {
            Console.Clear();
            DateTime stamp = DateTime.Now;
            int x = allPosts.Count;
            Console.WriteLine("Write a new post!");
            string post = Console.ReadLine();
            allPosts.Add(new Post(){Id = x, Text = post, TimeStamp = stamp});
            PostFile.SavePosts(allPosts);
            Console.Clear();
            Console.WriteLine("Press any key to see updated posts");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Updated Post List");
            PrintPosts(allPosts);
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }

        public static void PrintPosts(List<Post> allPosts)
        {
            foreach(Post post in allPosts)
            {
                Console.WriteLine(post.ToString());
            }
        }
    }
}