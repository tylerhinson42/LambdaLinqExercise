using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaLinqExercise
{
    class Program
    {
        private static object animalNames;

        static void Main(string[] args)
        {
            List<string> animalNames = new List<string>()

            {"Fawn", "gibbon", "heron", "jackalope", "ibex" };
            

            IEnumerable<string> longANimalNames =
                animalNames.OrderByDescending(x => x.Length);
        }
    }
}
