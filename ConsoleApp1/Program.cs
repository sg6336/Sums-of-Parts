using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumParts.PartsSums(new int[] { 0, 1, 3, 6, 10 }); // { 20, 20, 19, 16, 10, 0 }
        }
    }

    public class SumParts
    {

        public static int[] PartsSums(int[] ls)
        {
            List<int> result = new List<int>() { 0 };
            int sum = 0;
            for (int i = ls.Length - 1; i >= 0; i--)
            {
                sum += ls[i];
                result.Add(sum);
            }
            result.Reverse();

            return result.ToArray();
        }
    }
}


