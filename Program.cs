﻿using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace _03._09._2024_C__oppgave;


class Program


{
    static void Main(string[] args)
    {
        //Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int myNumber = 8685;
        //Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string myWords = "cool";
        //Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double myDecimal = 488.54;
        //Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        char myLetter = 'a';
        Console.WriteLine(myDecimal);
        Console.WriteLine(myWords);
        Console.WriteLine(myNumber);
        Console.WriteLine(myLetter);

        //Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        int[] theIntArray = { 1, 2, 3, 4, 5 };
        for (int i = 0; i <= 5; i++) ;

        //Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
        string[] theStringArray = { "cool", "waffle", "Grim" };
        foreach (string i in theStringArray)
        {
            Console.WriteLine(i);
        }

        //Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"
        List<string> thisList = new List<string>();
        thisList.Add("list element1");
        thisList.Add("list element2");
        foreach (string thisOne in thisList)
        {
            Console.WriteLine(thisOne);
        }

        //Ekstra oppgaver -----------------------------------------------------------------------------

        //Oppgave 1 
        //Main scope
        int A = 50;
        int B = 100;
        int result = AddingUp(A, B);
        Console.WriteLine(result);
    }
    //Outside mainscope
    static int AddingUp(int A, int B)
    {
        int sum = A + B;
        return sum;
    }
    //OPPGAVE 1 

    static int ArrayMethod(int[] argument)
    {
        int Counter = 0 >=;
        SumArray(int)
        return argument;
    }
};
