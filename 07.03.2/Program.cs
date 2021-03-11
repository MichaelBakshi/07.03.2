using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._03._2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>()
            {
                "Billy", "Bob", "Marley", "John", "Ian", "Eva", "Kianu", "Jonathan", "Leo", "William"
            };

         
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();

            List<string> more_than_4_letters = names.Where(x => x.Length>4).ToList();
            more_than_4_letters.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            List<string> with_a_letter = names.Where(x => x.Contains("a")).ToList();
            with_a_letter.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            List<string> ordered_by = names.OrderBy(x => x).ToList();
            ordered_by.ForEach(x => Console.WriteLine(x));
        }
    }
}
