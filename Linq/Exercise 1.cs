using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Exercise_1
    {
        int[] Rank = { 23, 35, 21, 45, 60, 70 };

        public void S()
        {
            IEnumerable<int> A = from Mark in Rank 
                                 where Mark > 30 
                                 select Mark;

            foreach (int i in A)
            {
                Console.Write(i + " ");
            }
        }

        IList<string> stringList = new List<string>()
        {
             "C# Tutorials",
            "VB.NET Tutorials",
             "Learn C++",
             "MVC Tutorials" ,
              "Java"
        };

        public void R()
        {
            var result = from S in stringList where S.Contains("Tutorials") select S;
        }

       


    }
}
