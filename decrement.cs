using System;
using System.Collections.Generic;
using System.Text;
/*  Calculating pre-decrement and post-decrement
    Author: Shrivignesh
    Date: 3/02/2021  */

namespace TrainingSessionExamples
{
    class decrement
    {

        static void Main(string[] args)
        {
            // Initializing a variable
            int a = 52;
            
            // Display an output
            Console.WriteLine("The value is: " + a);
            Console.WriteLine("The  Post decremented value is:" + a--);
            Console.WriteLine("The  Pre decremented value is:" + --a);

        }
    }
}
