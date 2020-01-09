using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("harsha");
            name.Add("Santhosh");
            name.Add("Rakesh");
            name.Add("Ramana");
            var result = Enumerable.Where(name,n => n.Contains("h"));
            var orderedResult = result.OrderBy(n=>n.Length);
            var result1 = (from n in name where n.Contains("h") orderby n select n.ToUpper()).Reverse();
            //using contains and where operation
            foreach(var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("..........................................");

            //using orderby operation
            foreach (var v in orderedResult)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("..........................................");
            //using reverse operation
            foreach(var v in result1)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("..........................................");
            //Taking First two strings in a list
            var result2 = name.Where(n => n.Length == 6).Select(n => n).Take(2);
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("..........................................");
            //Concat and Union
            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };
            IEnumerable<int> concat = seq1.Concat(seq2);
            IEnumerable<int> union = seq1.Union(seq2);
            foreach (var v in concat)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine("\n");
            foreach (var v in union)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine("\n..........................................");
            //adding element after calculating lengths
            IEnumerable<int> lengths = name.Select(n => n.Length);
            name.Add("Teja");
            foreach (var v in lengths)
            {
                Console.Write(v + " ");
            }
            name.Add("champ");
            Console.WriteLine("\n");
            foreach (var v in lengths)
            {
                Console.Write(v + " ");
            }
            Console.ReadKey();
        }
    }
}
