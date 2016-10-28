using System;

namespace HomeworkControlFlow.Task2
{
    class RefactorLoop
    {
        public void MainMethod(object[] array, object expectedValue)
        {
            int lenght = array.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
