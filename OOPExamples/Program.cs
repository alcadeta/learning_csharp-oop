using System;
using OOPExamples;

class Program
{
    static void Main(string[] args)
    {
        var computer = new Computer();
        Console.WriteLine($"Computer Type => {computer.GetType()}");

        var isComputer = computer is Computer;
        Console.WriteLine($"Is Computer => {isComputer}");

        Console.Read();
    }
}