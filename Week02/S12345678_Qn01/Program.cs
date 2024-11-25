using System;
using System.Collections.Generic;

namespace Week02
{
    class Question01
    {
        static void Main()
        {
            //A
            int[] integerArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter integer {i + 1}: ");
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int integer in integerArray)
            {
                Console.WriteLine(integer);
            }

            //B
            List<int> integerList = new List<int>(integerArray);

            while (true)
            {
                Console.Write("Enter an integer: ");
                int inputInteger = Convert.ToInt32(Console.ReadLine());

                if (inputInteger == -1)
                {
                    break;
                }
                
                else
                {
                    integerList.Add(inputInteger);
                }
            }

            foreach (int integer in integerList)
            {
                Console.WriteLine(integer);
            }

            //C
            Stack<int> integerStack = new Stack<int>(integerList);

            integerStack.Push(56); integerStack.Push(72);

            foreach (int integer in integerStack)
            {
                Console.WriteLine(integer);
            }

            integerStack.Pop();

            Console.WriteLine("New pop:");
            foreach (int integer in integerStack)
            {
                Console.WriteLine(integer);
            }

            //D
            Queue<int> integerQueue = new Queue<int>(integerList);

            integerQueue.Enqueue(23); integerQueue.Enqueue(45);

            foreach (int integer in integerQueue)
            {
                Console.WriteLine(integer);
            }

            integerQueue.Dequeue();

            Console.WriteLine("New dequeue:");
            foreach (int integer in integerQueue)
            {
                Console.WriteLine(integer);
            }
        }
    }
}