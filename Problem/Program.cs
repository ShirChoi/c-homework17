using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4, 5, 6, 7};

            /*int del = ArrayHelper.Pop(ref arr);
            ArrayHelper.PrintArr(arr);
            System.Console.WriteLine();
            System.Console.WriteLine($"del = {del}");*/
            
            /*int newLen = ArrayHelper.Push(ref arr, 4);
            System.Console.WriteLine($"new length: {newLen}");
            ArrayHelper.PrintArr(arr);*/

            /*int del = ArrayHelper.Shift(ref arr);
            ArrayHelper.PrintArr(arr);
            System.Console.WriteLine();
            System.Console.WriteLine(del);*/

            /*int newLen = ArrayHelper.UnShift(ref arr, 0);
            System.Console.WriteLine($"new length: {newLen}");
            ArrayHelper.PrintArr(arr);*/

            /*int[] narr = ArrayHelper.Slice(arr, -2);
            ArrayHelper.PrintArr(narr);*/

            string[] animals = new string[] { "ant", "bison", "camel", "duck", "elephant" };
/*
            ArrayHelper.PrintArr(ArrayHelper.Slice(animals, 2));
            System.Console.WriteLine();
            ArrayHelper.PrintArr(ArrayHelper.Slice(animals, 2, 4));
            System.Console.WriteLine();
            ArrayHelper.PrintArr(ArrayHelper.Slice(animals, 1, 5));
            */

        }
    }
}
