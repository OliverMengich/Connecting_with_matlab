using System;
using System.Collections.Generic;
using System.Text;

namespace Connect_with_matlab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome we are connecting with matlab shortly");

            // Creating the matlab instance
            MLApp.MLApp matlab = new MLApp.MLApp();

            // add the directory of the function
            matlab.Execute(@"cd D:\");

            // define the output of the result
            object result = null;

            // call the MATLAB function myfunc
            matlab.Feval("myfunc",2, out result,3.14,42.0,"OLIVER KIPKEMEI MENGICH");

            // display the result of your output
            object[] res = result as object[];

            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.ReadLine();

        }
    }
}
