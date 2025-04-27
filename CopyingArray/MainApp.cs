using System;

namespace CopyingArray
{
    class MainApp
    {
        static void CopyArray<T>(T[] array) // <T>를 사용함으로써 int형식 메서드, string형식 메서드 등 하나하나 만들 필요가 없다
        {                                   // 즉 그것이 바로 Generic Programming이다.
            foreach (var arr in array)
            {
                Console.Write($"{arr} ");
            }
            Console.WriteLine();
        }
                
        static void Main(string[] args)
        {            
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            CopyArray<int>(array);

            string[] strarray = new string[] { "부장", "차장", "과장" };
            CopyArray<string>(strarray);
        }
    }
}
