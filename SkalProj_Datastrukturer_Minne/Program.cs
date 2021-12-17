using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {





            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. CheckAllAlphabets"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ChecAllAlphabets();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

       

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();


            Console.WriteLine($" Write before the text  '+'   if you want to add in the list or  '-'   to remove from the list or '0' to exit.");
            do
            {

                string input = Console.ReadLine();

                char nav = input[0];



                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("some error occurs");
                        break;
                }



                Console.WriteLine($"The list count { theList.Count} ");

                Console.WriteLine($"The list capacity {theList.Capacity}");


            } while (true);

            // theList.Capacity kollar hur stor listan är
            // theList.Count kollar hur många element som finns i listan
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> theQueue = new Queue<string>();
            Console.WriteLine($" Write before the text  '+'   if you want to add in the list or  '-'   to remove from the list or '0' to exit.");

            do
            {

                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("some error occur");
                        break;
                }

                Console.WriteLine("\n...After Enqueue or Dequeue...\n");

                foreach (string item in theQueue)
                {
                    Console.WriteLine(item);
                }

            } while (true);

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<char> theStack = new Stack<char>();
            Console.WriteLine($" Write before the text  '+'   if you want to add in the list or  '-'   to remove from the list or '0' to exit.");

            while (true)
            {

                string text = Console.ReadLine();

                char nav = text[0];

                string value = text.Substring(1);

                switch (nav)
                {
                    case '+':
                        for (int i = 0; i < value.Length; i++) { theStack.Push(value[i]); }
                        break;
                    case '-':
                        for (int i = theStack.Count; i > 0; i--) { Console.Write(theStack.Pop()); }
                        Console.WriteLine();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;

                }

            }

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );

             */
            Stack<char> theStack = new Stack<char>();
            Console.WriteLine($" Write before the format after '+' or '0' to exit.");

            while (true)
            {
                string text = Console.ReadLine();

                char nav = text[0];

                string value = text.Substring(1);

                int x = value.Length / 2;
                string inreverse = value.Substring(0, x);
                string reverse = value.Substring(x);

                switch (nav)
                {
                    case '+':
                        for (int i = 0; i < inreverse.Length; i++)
                        {
                            switch (inreverse[i])
                            {
                                case '{':
                                    theStack.Push('}');
                                    break;
                                case '<':
                                    theStack.Push('>');
                                    break;
                                case '(':
                                    theStack.Push(')');
                                    break;
                                case '[':
                                    theStack.Push(']');
                                    break;

                            }
                        }
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;

                }
                string str = new string(theStack.ToArray());
               
                if (str == reverse)
                {
                    Console.WriteLine("Correct format");
                }
                else
                {
                    Console.WriteLine("Wrong format");
                }

                theStack.Clear();
            }

        }
        private static void ChecAllAlphabets()
        {
            string allAlphabets = "abcdefghijklmnopqrstuvwxyz";

            bool checkTrue = true;

            List<char> checkAlphabet = new List<char>();

            Console.WriteLine("Enter the text to be Checked.");

            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                checkAlphabet.Add(input[i]);
            }

            

            for(int i = 0; i < allAlphabets.Length; i++)
            {
               
                
                if (!(checkAlphabet.Contains(allAlphabets[i])))
                {
                    Console.WriteLine("Not all alphets are contained");
                    checkTrue = false;
                    break;
                        
                }
               
            }

            if (checkTrue) { Console.WriteLine("All the alphabets are contained in the text you entered"); }

        }
    }
}

