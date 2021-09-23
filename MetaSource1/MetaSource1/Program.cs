using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaSource1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Results {
        public char Character { get; set; }
        public int Occurence { get; set; }
    }
    static class CharacterFind { 
        static public Results Process(string str)
        {
            var sentence = str;

            var map = new Dictionary<char, int>();
            char highestCharValue = new char();
            int highestCharCount = 1;

            // eliminate non characters and upper cases in enumeration
            foreach (var s in sentence.Where(s => !string.IsNullOrWhiteSpace(s.ToString()) && !char.ToUpper(s).Equals(s)))
            {
                // keep track of current occurrences
                if (!map.ContainsKey(s)) map[s] = 1;
                else map[s] = map[s] + 1;
                // compare against known highest char count
                if (map[s] > highestCharCount)
                {
                    highestCharValue = s;
                    highestCharCount = map[s];
                }
            }
            return new Results { c = highestCharValue, occurance = highestCharCount };
        }
    }
}
