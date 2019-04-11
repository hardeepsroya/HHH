using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0703625
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
        }
        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {
            {
                int counter = 0;
                string ln;
                while ((in= FileStyleUriParser.ReadLine())!= null)
                {
                    Console.WriteLine(Ln);
                    Beowulf.Add(Ln);
                }
                File.Close();
                Console.WriteLine($"")
            }
        }
        public int FindNumber of BlankSpaces( string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach ( char c in line)
            {
                if (char.IsLetter(C)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }
    }
}
