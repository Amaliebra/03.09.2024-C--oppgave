using System.Drawing;
using System.Runtime.InteropServices;

namespace _03._09._2024_C__oppgave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int myNumber = 8685;
        string myWords = "cool";
        double myDecimal = 488.54;
        char myLetter = 'a';
        Console.WriteLine(myDecimal);
        Console.WriteLine(myWords);
        Console.WriteLine(myNumber);
        Console.WriteLine(myLetter);

        int[] theIntArray = { 1, 2, 3, 4, 5 };
        for (int i = 0; i <= 5; i++) ;

        string[] theStringArray = { "cool", "waffle", "Grim" };
        foreach (string i in theStringArray)
        {
            Console.WriteLine(i);
        }

        List<string> thisList = new List<string>();
        thisList.Add("list element1");
        thisList.Add("list element2");
        foreach (string thisOne in thisList)
        {
            Console.WriteLine(thisOne);
        }




    }
}

