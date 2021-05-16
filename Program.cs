using System;

namespace OOPExamples
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // var computer = new Desktop("Generic Computer", CaseType.Tower);
            var computer = new Laptop("Generic Laptop", 1024, 768);

            Console.WriteLine($"Computer Type => {computer.GetType()}");
            Console.WriteLine($"Computer Name => {computer.Name}");
            // Console.WriteLine($"Computer Case => {computer.CaseType}");

            var isComputer = computer is Computer;
            Console.WriteLine($"Is Computer => {isComputer}");

            computer.TogglePower();
            Console.WriteLine($"Computer is On => {computer.IsOn}");

            var sleepingComputer = computer as ISleep;
            if (sleepingComputer != null)
            {
                sleepingComputer.ToggleSleep();
                Console.WriteLine($"Computer is Sleeping => {sleepingComputer.IsSleeping}");
            }

            computer.TogglePower();
            Console.WriteLine($"Computer is On => {computer.IsOn}");

            Console.Read();
        }
    }
}