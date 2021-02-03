using System;
using System.Collections.Generic;
using System.Text;
/*  Calculating pre-increment and post-increment
    Author: Shrivignesh
    Date: 3/02/2021  */

namespace TrainingSessionExamples
{
    class increment
    {

        static void Main(string[] args)
        {
            int a = 52;
            // Display an output
            Console.WriteLine("The value is: " + a);
            Console.WriteLine("The  Post incremented value is:" + a++);
            Console.WriteLine("The  Pre incremented value is:" + ++a);

        }
    }
}
