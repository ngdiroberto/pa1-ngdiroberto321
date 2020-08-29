using System;
using System.Collections.Generic;
using System.IO;

namespace pa1_ngdiroberto321
{
    public class FileControl
    {
        private static List<Post> posts = new List<Post>(); //List of Post objects

        public static List<Post> PostList{ //Accessor and Mutator for posts list
            get{return posts;} 
            set{posts = value;}
        }

        public static void Save(){ //saves list to posts.txt file
            File.Create("posts.txt").Close();
            StreamWriter outFile = new StreamWriter("posts.txt", true);

            foreach(Post post in posts){
                String input = post.ID + "#" + post.PostText + "#" + post.Date;
                outFile.WriteLine(input);
            }
            outFile.Close();
        }

        public static void Clone(){ //clones list from post.txt file at beginning of runtime
            try{
                List<Post> temp = new List<Post>();
                StreamReader inFile= new StreamReader("posts.txt");
                
                String input = inFile.ReadLine();
                while(input != null){
                    String[] array = input.Split('#');
                    temp.Add(new Post(){ID = array[0], PostText = array[1], Date = array[2]});
                    input = inFile.ReadLine();
                }
                temp.Sort();
                temp.Reverse();
                inFile.Close();
                posts = temp;
            }
            catch (Exception e){
                Console.WriteLine("ERROR: File has failed to open correctly. Please restart application.");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}