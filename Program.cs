using System;
using System.IO;
using System.Collections.Generic;

namespace pa1_321
{
    class Program
    //check for missing using statements
    {
        //Menu
        static void Main(string[] args)
        {
            List<Post> allPosts = PostFile.GetPosts();
            Menu(allPosts);
            Console.ReadKey();
        }

        static void Menu(List<Post> allPosts)
        {
            string choice = GetChoice();
            while (choice != "4")
            {
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Posts displayed here: ");
                    Utilities.PrintPosts(allPosts);
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to the main menu");
                    Console.ReadKey();
                    Console.Clear();
                    Menu(allPosts);
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Utilities.AddPost(allPosts);
                    Menu(allPosts);
                    Console.ReadKey();
                }
                //remove
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Delete a post by ID");
                    
                    int foundIndex = myPost.FindIndex(tempPost => tempPost == Post);
                    if(foundIndex != -1)
                    {
                        myPost.RemoveAt(foundIndex);
                    }
                    Console.ReadKey();
                    //not working as intended
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The choice you entered is invalid. \n Press any key to return to the main menu");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Please enter a valid choice");
                    choice = GetChoice();
                }
            }
        }

        static string GetChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Show all posts");
            Console.WriteLine("2. Add a post");
            Console.WriteLine("3. Delete a post");
            Console.WriteLine("4. Exit Application");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
