using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadParameters
{

    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            double floatPoint;
            char character;
            bool flag;
            string text;
            Console.WriteLine("Please enter : int,double,tav,bool & text.");
            integer = int.Parse(Console.ReadLine());
            floatPoint = double.Parse(Console.ReadLine());
            character = char.Parse(Console.ReadLine());
            flag = bool.Parse(Console.ReadLine());
            text = Console.ReadLine(); // No need to Parse it!
            Console.WriteLine("int is {0}, double is {1},char is {2} , bool is {3}, string is {4}.", integer, floatPoint, character, flag, text);
            Console.ReadKey();




        }




    }
}