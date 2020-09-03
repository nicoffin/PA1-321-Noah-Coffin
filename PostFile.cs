using System.IO;
using System;
using System.Collections.Generic;


namespace pa1_321
{
    public class PostFile
    {
        public static List<Post> GetPosts()
        {
            List<Post> allPosts = new List<Post>();
            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("ERROR... Blank list being displayed{0}", e);
                return allPosts;
            }
            
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                int id = int.Parse(temp[0]);
                allPosts.Add(new Post(){Id = x, Text = temp[1], TimeStamp = DateTime.Parse(temp[2])});
                line = inFile.ReadLine();
            }
            inFile.Close();
            return allPosts;
        }   
        //inFile
        public static void SavePosts(List<Post> allPosts)
        {
            StreamWriter outFile = new StreamWriter("posts.txt");
            foreach(Post post in allPosts)
            {
                outFile.WriteLine(post.Id + "#" + post.Text + "#" + post.TimeStamp);
            }
            outFile.Close();
            //outFile
        }
//         try
//     Pass the file path and file name to the StreamReader constructor
//     StreamReader sr = new StreamReader("sample");
//     Read the first line of text
//     line = sr.ReadLine();
//     Continue to read until you reach end of file
//     while (line != null)
//     {
//       write the lie to console window
//         Console.WriteLine(line);
//       Read the next line
//         line = sr.ReadLine();
//     }
//     close the file
//     sr.Close();
//     Console.ReadLine();
// }
// catch(Exception e)
// {
//     Console.WriteLine("Exception: " + e.Message);
// }
// finally
// {
//     Console.WriteLine("");
// }
// no reason to use
    }
}