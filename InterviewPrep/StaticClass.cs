using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public static class StaticClass
    {
        static int size {get;set;}

        public static void IncrementSize()
        {
            if (size < 0)
                size = 0;
            else
                size++;
        }

    }
}
