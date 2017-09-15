using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;

            Console.WriteLine("MinValue = {0} MaxValue = {1}", flmin, flmax);


            float flvar = 1F / 3;
            double dlvar = 1D / 3;
            decimal dcvar = 1M / 3;

            Console.WriteLine("\nfloat value = {0}\ndouble value = {1}\ndecimal value = {2}", flvar, dlvar, dcvar);
            



            Console.ReadKey();


            
        }
    }
}
