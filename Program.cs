using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program(); // Creating an instance
        }
        
        /**
        Constructor of the class( execs automatically when an instance is created)
        Rules:
        - It MUST have the same name as the class
        - only method that DOES NOT contain return type
        */
        public Program()
        {
            Console.WriteLine("My Frist DotNet app");
        }

        void Test(){
            /*DATA types*/
            int age = 99;
            //floating point decimal
            float gravite = 9.8f;
            //decimal for money
            decimal money = 12.99m;
            // Boolean (true/false)
            bool IsThisCrazy = true;

            string text = "this is a string";

            Console.WriteLine("This is my name: Sheldon");

            if(money < 50){
                Console.WriteLine("It's cheap");
            }
            else{
                Console.WriteLine("It's expensive");
            }

        
            for(int i=0; i < 9; i++){
                Console.WriteLine("Iteration: " + i);
            }



        }

        /**
         MEthod (funttion)
         -acces level (optional, default is private)
         - return type (always return a value of that type)
         - Name of Method
         - parameters (type name, type name)
        */
        public int SayHello()
        {
            Console.WriteLine("I'm a method");
            bool isRainy = false;
            if(isRainy)
            {
                return 21;
            }
            else
            {
                return 6;  
            }
        }
    }
}
