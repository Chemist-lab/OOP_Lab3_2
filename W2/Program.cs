using System;
using System.IO;

namespace W2
{
    class Program
    {
        static string fileRead = @"f.txt";
        static string fileWrite = @"g.txt";
        static string readNums;
        static int CheckNum;
        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader(fileRead);
            StreamWriter writer = new StreamWriter(fileWrite, false, System.Text.Encoding.Default);
            readNums = reader.ReadToEnd();

            for(int i = 0; i < readNums.Length; i++)
            {
                CheckNum = readNums[i];
                if (CheckNum % 2 == 0)
                {
                    Console.WriteLine(readNums[i]);
                    writer.Write(readNums[i]);
                }
            }
            writer.Close();
        }
    }
}
