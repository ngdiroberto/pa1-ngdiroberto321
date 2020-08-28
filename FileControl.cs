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
            try{
                List<Post> temp = new List<Post>();
                StreamReader inFile= new StreamReader("posts.txt");
                
                String input = inFile.ReadLine();
                while(input != null){
                    String[] array = input.Split('#');
                    temp.Add(new Post(){ID = array[0], PostText = array[1], Date = array[2]});
                    input = inFile.ReadLine();
                }
                
                inFile.Close();
                posts = temp;
            }
            catch (Exception e){
            Console.WriteLine("ERROR: File cannot be opened");
            Console.WriteLine(e.Message);
            Console.ReadKey();
            }
        }
    }
}