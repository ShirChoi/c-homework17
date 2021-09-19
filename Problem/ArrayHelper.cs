using System;
namespace Problem {
    public static class ArrayHelper {

        public static void PrintArr<T>(in T[] arr) {
            foreach (T el in arr) {
                Console.Write($"{el} ");
            }    
        }

        public static T Pop<T>(ref T[] arr) {
            T res = arr[arr.Length - 1];
            Array.Resize<T>(ref arr, arr.Length - 1);

            return res;
        } 

        public static int Push<T>(ref T[] arr, in T elm) {
            Array.Resize<T>(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = elm;

            return arr.Length;
        }

        private static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        public static T Shift<T>(ref T[] arr) {
            for(int i = 0; i < arr.Length - 1; i++)
                Swap(ref arr[i], ref arr[i + 1]);
                
            T res = Pop(ref arr);

            return res;
        }

        public static int UnShift<T>(ref T[] arr, T elm) {
            Array.Resize(ref arr, arr.Length + 1);
            //PrintArr(arr);
            for(int i = arr.Length - 1; i > 0; i--)
                Swap(ref arr[i], ref arr[i - 1]);

            arr[0] = elm;
            return arr.Length;
        }

        public static T[] Slice<T>(in T[] arr, int beginIndex = 0, int endIndex = int.MaxValue) {
            if(endIndex == int.MaxValue)
                endIndex = arr.Length;
            
            beginIndex = beginIndex < 0 ? arr.Length + beginIndex : beginIndex;
            endIndex = endIndex < 0 ? arr.Length + endIndex : endIndex;

            if(endIndex < beginIndex || beginIndex >= arr.Length)
                return new T[0];
            
            T[] result = new T[endIndex - beginIndex];

            for(int i = beginIndex; i < endIndex; i++) 
                result[i - beginIndex] = arr[i];
            
            return result;
        }
    }
}