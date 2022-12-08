using System;

class Programm
{
    static void Main(string[] args)
    {
        Console.Write("v=");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.Next(0, 10);
        int temp;
        for (int i = 0; i < arr.Length - 3; i += 2)
            for (int j = 0; j < arr.Length - 2; j += 2)
                if (arr[j] > arr[j + 2])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 2];
                    arr[j + 2] = temp;
                }
        foreach (int v in arr)
            Console.Write("{0,3}", v);
        Console.ReadKey();
    }
}



