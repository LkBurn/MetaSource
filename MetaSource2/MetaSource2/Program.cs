using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetaSource2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string file1 = Directory.GetCurrentDirectory() + "\\CACities.txt";
            string file2 = Directory.GetCurrentDirectory() + "\\USCities.txt";
            string line1, line2;

            var file1Text = File.ReadLines(file1);
            var file2Text = File.ReadLines(file2);

            var usFileEnumerator = file1Text.GetEnumerator();
            var caFileEnumerator = file2Text.GetEnumerator();

            var currentUSItem = usFileEnumerator.Current;
            var currentCAItem = caFileEnumerator.Current;
            if()     
        }
    }

    public class Process
    {
        public ConcurrentQueue<string> Queue { get; set; } = new ConcurrentQueue<string>();
    }
}
