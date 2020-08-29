using System;
using System.Collections.Generic;
using System.IO;

namespace pa1_ngdiroberto321
{
    class Program
    {
        static void Main(string[] args)
        {
            FileControl.Clone();
            String input = "";

            while(input.CompareTo("4")!=0){
                PrintMenuOptions(); 
                ValidateMenuChoice(ref input); 
            }
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
                Console.WriteLine("\t" + post.ToString());
                count++;
            }
            Console.WriteLine("\n" + count + " posts shown.\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void AddPost(){
            List<Post> allPosts = FileControl.PostList;
            Guid g = Guid.NewGuid();
            string id = g.ToString();
            string text = "";
            DateTime currTime = DateTime.Now;

            Console.Write("Enter Post Message: ");
            text = Console.ReadLine();
            Console.Clear();

            allPosts.Add(new Post(){ID = id, PostText = text, Date = currTime.ToString()});
            FileControl.PostList = allPosts;
            FileControl.Save();
            Console.WriteLine("Post created successfully.\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void DeletePost(){
            List<Post> allPosts = FileControl.PostList;
            int count = 1;
            Console.WriteLine("All Posts\n---------");

            foreach(Post post in allPosts){
                Console.WriteLine("\t" + count + ". " + post.ToString());
                count++;
                
            }
            string input = "";
            Console.Write("\nPlease select item to delete (enter \"return\" to exit)): ");
            input = Console.ReadLine();
            Console.Clear();

            if(input.ToLower().Equals("return")) return;
            
            try{
                int value = int.Parse(input) - 1;
                allPosts.RemoveAt(value);
                FileControl.PostList = allPosts;
                FileControl.Save();

                Console.WriteLine("Post removed successfully.\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            catch(Exception e){
                Console.WriteLine("ERROR: Post cannot be deleted.");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
