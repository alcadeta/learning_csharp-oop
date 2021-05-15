using System;

namespace OOPExamples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var computer = new Desktop("Generic Computer", CaseType.Tower);
            Console.WriteLine($"Computer Type => {computer.GetType()}");
            Console.WriteLine($"Computer Name => {computer.Name}");
            Console.WriteLine($"Computer Case => {computer.CaseType}");

            var isComputer = computer is Computer;
            Console.WriteLine($"Is Computer => {isComputer}");

            computer.TogglePower();
            Console.WriteLine($"Computer is On => {computer.IsOn}");

            computer.ToggleSleep();
            Console.WriteLine($"Computer is Sleeping => {computer.IsSleeping}");

            computer.TogglePower();
            Console.WriteLine($"Computer is On => {computer.IsOn}");

            Console.Read();
        }
    }
}