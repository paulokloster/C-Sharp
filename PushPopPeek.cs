/* ______        ______  ____   ___  _  _     ____        _          ____  _                   _                          ___        _    _                  _ _   _                   
  / ___\ \      / /  _ \| ___| / _ \| || |   |  _ \  __ _| |_ __ _  / ___|| |_ _ __ _   _  ___| |_ _   _ _ __ ___  ___   ( _ )      / \  | | __ _  ___  _ __(_) |_| |__  _ __ ___  ___ 
  \___ \\ \ /\ / /| | | |___ \| | | | || |_  | | | |/ _` | __/ _` | \___ \| __| '__| | | |/ __| __| | | | '__/ _ \/ __|  / _ \/\   / _ \ | |/ _` |/ _ \| '__| | __| '_ \| '_ ` _ \/ __|
   ___) |\ V  V / | |_| |___) | |_| |__   _| | |_| | (_| | || (_| |  ___) | |_| |  | |_| | (__| |_| |_| | | |  __/\__ \ | (_>  <  / ___ \| | (_| | (_) | |  | | |_| | | | | | | | \__ \
  |____/  \_/\_/  |____/|____/ \___/   |_|   |____/ \__,_|\__\__,_| |____/ \__|_|   \__,_|\___|\__|\__,_|_|  \___||___/  \___/\/ /_/   \_\_|\__, |\___/|_|  |_|\__|_| |_|_| |_| |_|___/
    C# program to demonstrate push, pop, peek                                                                                               |___/       
*/ 
using System;
using System.Collections.Generic; //compulsory to be defined


namespace StackProg
{
    class StackPushPopPeek      //  Stack - LIFO = Last In First Out 
    {
        static void Main(string[] args)
        {
            //----------------------ADDINNG ELEMENTS TO STACK-------------------

            //declaring variable string type
            string UserInput;      

            Stack<string> mystack = new Stack<string>();

            //using foreach loop to find the caractheres      
            for(int i=0;i<5;i++)       //setting how many times the user can input a value, in this case the user can input a value 5 times
            {
                Console.Write("PLEASE ENTER A COUNTRY : ");
                UserInput = Console.ReadLine();     //This code will let user enter input and save it in the stack, in this case will be saved in mystack       //lets say user will enter Brazil, Usa, Canada, Japan, India for example
                mystack.Push(UserInput);
            }
                       
            
            Stack<string> mystack1 = new Stack<string>();

            foreach (string paulo in mystack)
            {
                mystack1.Push(paulo);       //run 5times
                
            }


            //Console.WriteLine("\nPLEASE SELECT 1 TO INSERT - 2 TO REMOVE - OR 3 TO CHECK ELEMENTS IN THE LIST CONTAINS \n");

            Console.WriteLine("\nPLEASE SELECT 1 TO REMOVE USING POP METHOD - OR - PLEASE SELECT 2 TO PEEK THE LAST ELEMENT IN THE LIST AND DISPLAY THE REMAINING STACK USING PEEK METHOD \n");        //after the user enter enter his input(values) 5 times, the switch cases will be executed after user choose a option


            int userInput = Convert.ToInt32(Console.ReadLine());  //ASK YOUR INPUT WITH THIS CODE, what user type will be saved inside userInput, then execute the option choosed


            switch (userInput)
            {   

                case 1: //------------------POP METHOD----------------------------------------
                    {
                        Console.WriteLine("\nOption 1 selected - POP VALUES THREE TIMES AND DISPLAYING REMAINING STACK");

                        try
                        {

                            {

                                Console.WriteLine("Removing values....");
                                mystack.Pop();            //if user enter Brazil, Usa, Canada, Japan, India for example.... India will be the first element to be removed from the list if use POP method
                                mystack.Pop();
                                mystack.Pop();

                                Console.WriteLine("Current stack is: ");
                                foreach (string c in mystack)
                                {
                                    Console.Write(c + " "); // C B A
                                }
                            }

                        }

                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        finally
                        {
                            Console.WriteLine("");              //This is Finally block and get executed regardless
                        }
                        break;
                    }
                case 2: //-----------------------------------PEEK METHOD------------
                    {
                        Console.WriteLine("\nOption 2 selected - PEEK THE STACK AND DIPSPLAYING THE VALUE THAT WAS PEEKED");
                        Console.WriteLine("\nThe next poppable value in stack: {0}", mystack.Peek());       //This code returns the top elements from the stack. in this case is the user inputs
                        Console.WriteLine("\nCurrent stack: ");


                        foreach (string c in mystack)
                        {
                            Console.WriteLine(c + " ");
                        }
                        Console.WriteLine();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
