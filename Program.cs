using System;

namespace pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "";

            while(true){
                PrintMenuOptions(); //Prints menu options to console
                ValidateMenuChoice(ref input); //facilitates menu option selection
                if(input.CompareTo("4")==0){
                    Console.Clear();
                    return;
                }
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
                    //Show.Run();
                    Console.WriteLine("Run Show Function...");
                    Console.ReadKey();
                    return;
                case "2":
                    //Add.Run();
                    Console.WriteLine("Run Add Function...");
                    Console.ReadKey();
                    return;
                case "3":
                    //Delete.Run();
                    Console.WriteLine("Run Delete Function...");
                    Console.ReadKey();
                    return;
                case "4":
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("ERROR: Menu option not found.\nPress any key to continue...");
                    Console.ReadKey();
                    return;
            }
        }
    }
}
