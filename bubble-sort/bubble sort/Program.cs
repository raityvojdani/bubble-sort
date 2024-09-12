using System;
using System.Linq;

namespace BubbleSort
{
    /// <summary>
    /// The main class containing the entry point of the program.
    /// </summary>
    internal class Program
    {
        private readonly IInputReader _inputReader;
        private readonly ISorter _sorter;
        private readonly IOutputWriter _outputWriter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class with the specified dependencies.
        /// </summary>
        /// <param name="inputReader">The input reader.</param>
        /// <param name="sorter">The sorter.</param>
        /// <param name="outputWriter">The output writer.</param>
        public Program(IInputReader inputReader, ISorter sorter, IOutputWriter outputWriter)
        {
            _inputReader = inputReader;
            _sorter = sorter;
            _outputWriter = outputWriter;
        }

        /// <summary>
        /// The main entry point of the program.
        /// </summary>
        private static void Main()
        {
            var program = new Program(new ConsoleInputReader(), new BubbleSorter(), new ConsoleOutputWriter());
            program.Run();
        }

        /// <summary>
        /// Runs the program by reading, sorting, and displaying numbers.
        /// </summary>
        public void Run()
        {
            int[] numbers = _inputReader.ReadNumbers();
            _sorter.Sort(numbers);
            _outputWriter.WriteNumbers(numbers);
        }
    }
}
