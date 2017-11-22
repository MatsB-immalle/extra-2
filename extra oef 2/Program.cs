using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extra_oef_2
{
    class Program
    {
        static void Main(string[] args)
        {


            IsVeelvoudVan(3, 11);



           
        }


        static void IsVeelvoudVan(int getal, int veelvoud)
        {
            bool waarheid = false;
            if(veelvoud % getal ==0)
            {
                waarheid = true;
            }
            Console.WriteLine(waarheid);



        }
    }
}
