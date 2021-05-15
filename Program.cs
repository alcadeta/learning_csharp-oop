using System;
using OOPExamples;

class Program
{
    static void Main(string[] args)
    {
        var computer = new Computer("Generic Computer");
        var isComputer = computer is Computer;

        Console.WriteLine($"Computer Type => {computer.GetType()}");
        Console.WriteLine($"Computer Name => {computer.Name}");
        Console.WriteLine($"Is Computer => {isComputer}");

        computer.TogglePower();
        Console.WriteLine($"Computer is On => {computer.IsOn}");

        computer.TogglePower();
        Console.WriteLine($"Computer is On => {computer.IsOn}");

        Console.Read();
    }
}