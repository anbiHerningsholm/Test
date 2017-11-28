using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace caTextfile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Read();
        }
        public static string GetLine()
        {
            Console.Write("? ");
            return Console.ReadLine();
        }

        public static void PutLine(string line)
        {
            Console.WriteLine(line);
        }

        public static void Write()
        {
            StreamWriter writer = new StreamWriter("Tekst.txt"); // C:\\Users\\ANBI\\Documents\\Test
            string line = GetLine();
            while (line.Length > 0)
            {
                writer.WriteLine(line);
                line = GetLine();
            }
            writer.Close();
        }

        public static void Read()
        {
            StreamReader reader = new StreamReader("Tekst.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                PutLine(line);
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
