using System;
using System.Collections.Generic;

namespace arrayAndListTask
{
    class Program {
        public static void Main(string[] args) {


            // using arrays
            string[] exercise1Array = new string[5];
            int[] exercise2Array = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            int exercise2Total = 0;

            // exercise 1
            for (int i = 0; i < exercise1Array.Length; i++)
            {
                exercise1Array[i] = Console.ReadLine();
            }
            foreach (string name in exercise1Array)
            {
                Console.WriteLine("hello {0}",name);
            }
            // exercise 2
            foreach (int number in exercise2Array)
            {
                exercise2Total += number;
            }
            Console.WriteLine(exercise2Total);


            // using lists

            List<int> exercise1List = new List<int>();
            List<int> exercise2List = new List<int>();
            List<string> exercise3List = new List<string>();

            //exercise 1
            for (int i = 0;i< 5;i++)
            {
                Console.Write("\n Enter number : ");
                exercise1List.Add(int.Parse(Console.ReadLine()));
            
            }
            int exercise1Selection = int.Parse(Console.ReadLine());
            foreach(int exercise1Number in exercise1List)
            {
                if (exercise1Number == exercise1Selection) { Console.WriteLine("Number is a duplicate / exists in list"); break; }
            }
            //exercise 2
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n Enter number : ");
                exercise2List.Add(int.Parse(Console.ReadLine()));

            }
            int exercise2Selection = int.Parse(Console.ReadLine());
            exercise2List.Add(exercise2Selection);
            
            int listLength = 0;
            foreach (int exercise2Number in exercise2List)
            {
                List<int> existsAt = new List<int>();
                Console.WriteLine("\n {0} ", exercise2Number);
                int loc = exercise2List.IndexOf(exercise2Number);
                while (loc !=-1)
                {
                    loc = exercise2List.IndexOf(exercise2Number, loc + 1);
                    existsAt.Add(loc);
                }
                listLength = existsAt.Count;
                if(listLength > 1)
                {
                    Console.WriteLine(" {0} is a duplicate and occurs {1} times", exercise2Number, listLength);
                } else
                {
                    Console.WriteLine(" {0} is not a duplicate and occurs once", exercise2Number);
                }
                existsAt.Clear();
                
            }

            bool notStopped = true;
            while(notStopped)
            {
                Console.Write("\n\n enter text : ");
                string exercise3Input = Console.ReadLine();
                if (exercise3Input.ToUpper() == "STOP")
                {
                    notStopped = false;
                } else
                {
                    exercise3List.Add(exercise3Input);
                }
            }
            // the method exists for a reason, i am coding this at 4 am tim i cannot think of a way to do this atm so im going to be lazy, sorry
            exercise3List.Reverse();
            foreach (string item in exercise3List)
            {
                Console.WriteLine(item);
            }


        }
    }

}

