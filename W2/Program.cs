using System;
using System.IO;
using System.Linq;

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
            int[] nums = readNums.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                CheckNum = nums[i];
                if (CheckNum % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                    writer.Write(nums[i]+"\n");
                }
            }
            writer.Close();
        }
    }
}
