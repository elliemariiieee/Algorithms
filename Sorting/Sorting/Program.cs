using System.Timers;

namespace Sorting
{
    internal class Program
    {
        private static System.Diagnostics.Stopwatch watch;
        static void Main(string[] args)
        {
            Bubble b = new Bubble();
            Heap h = new Heap();
            Insertion i = new Insertion();
            Merge m = new Merge();
            Quick q = new Quick();
            Selection s = new Selection();

            //gets input from external file
            List<string> files = new List<string>();
            List<string> lines = new List<string>();
            string path = "..\\..\\..\\Files";
            StreamReader reader;
            files = Directory.GetFiles(path).ToList();
            for (int x = 0; x < files.Count; x++)
            {
                reader = new StreamReader(files[x]);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            //converts list from string to int
            List<int> scores = new List<int>();
            scores = lines.Select(int.Parse).ToList();

            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            b.Run(scores);
            watch.Stop();
            Console.WriteLine($"Bubble Sort is an algorithm that compares the current value to the previous one and repeats until all values are sorted. It sorted the data in {watch.ElapsedMilliseconds} ms. Psuedocode for the alogrithm follows:");
            Console.WriteLine("Bubblesort(Data: values[])\n  Boolean: not_sorted = True\n  While(not_sorted)\n    not_sorted = False\n    For i = 0 To <length of values> - 1\n      If(values[i] < values[i-1]) Then\n        Data: temp = values[i]\n        values[i] = values[i-1]\n        values[i-1] = temp\n        not_sorted = True\n      End If\n    Next i\n  End While\nEnd Bubblesort");
            
        }

    }
}