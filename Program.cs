using System;
using System.Collections.Generic;
using System.IO;

namespace pa1_ngdiroberto321
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Clone();
            String input = "";

            while(input.CompareTo("4")!=0){
                PrintMenuOptions(); 
                ValidateMenuChoice(ref input); 
            }

            //File.Save();
        }

        public static void PrintMenuOptions(){
            Console.Clear();
            Console.WriteLine("Big Al Goes Social");
            Console.WriteLine(" 1.\tShow All Posts");
            Console.WriteLine(" 2.\tAdd Post");
            Console.WriteLine(" 3.\tDelete Post");
            Console.WriteLine(" 4.\tExit\n");
        }

        public static void ValidateMenuChoice(ref String input){
            Console.Write("Please select menu choice and press enter to confirm: ");
            input = Console.ReadLine();
            Console.Clear();

            switch(input){
                case "1":
                    ShowPosts();
                    break;
                case "2":
                    AddPost();
                    break;
                case "3":
                    DeletePost();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("ERROR: Menu option not found.\nPress any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        public static void ShowPosts(){
            List<Post> allPosts = FileControl.PostList;
            int count = 0;

            Console.WriteLine("All Posts\n---------");
            foreach(Post post in allPosts){
                Console.WriteLine("\t" + post.ID + "" + post.PostText + "" + post.Date);
                count++;
            }
            Console.WriteLine("\n" + count + " posts shown.\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void AddPost(){

        }

        public static void DeletePost(){

        }
    }
}
