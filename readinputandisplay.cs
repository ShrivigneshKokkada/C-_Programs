using System;
using System.Collections.Generic;
using System.Text;
/*  Reading Integer input and displaying the same
    Author: Shrivignesh
    Date: 3/02/2021  */

namespace TrainingSessionExamples
{
    class readinputandisplay
    {
        static void Main(string[] aregs)
        {
            Console.WriteLine("Enter the value for a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is:"+a);
        }

    }
}
