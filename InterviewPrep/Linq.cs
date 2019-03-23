using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Linq : DerivedInterface
    {
        public void DoStuff()
        {
            int[] numbers = {13,53,98,1,22};
            string[] words = { "believe", "relief", "receipt", "field" };
            var a = words.Select(w => w).Where(w => w.Contains("ie"));

            bool allContain = words.All(w => w.Contains("ie"));
            numbers.Average();
            numbers.Distinct();
            numbers.Except(numbers);

        }

        public void ShowBaseInterface()
        { Console.WriteLine("Show base interface from class"); }

        public void ShowDerivedInterface()
        { Console.WriteLine("Show derived interface from class"); }
    }
}
