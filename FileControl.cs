using System;
using System.Collections.Generic;
using System.IO;

namespace pa1_ngdiroberto321
{
    public class FileControl
    {
        private static List<Post> posts = new List<Post>();

        public static List<Post> PostList{
            get{return posts;} 
            set{posts = value;}
        }

        public static void Save(){
            File.Create("posts.txt").Close();
            StreamWriter outFile = new StreamWriter("posts.txt", true);

            foreach(Post post in posts){
                String input = post.ID + "#" + post.PostText + "#" + post.Date;
                outFile.WriteLine(input);
            }

            outFile.Close();
        }

        public static void Clone(){
            StreamReader inFile = new StreamReader("posts.txt");

        }
    }
}