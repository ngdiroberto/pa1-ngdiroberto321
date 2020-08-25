using System;

namespace pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;

            while(true){
                PrintMenuOptions(); //Prints menu options to console
                ValidateMenuChoice(ref input); //facilitates menu option selection
                if(input = "4"){
                    return;
                }
            }
        }

        public static void PrintMenuOptions(){
            
        }
    }
}
