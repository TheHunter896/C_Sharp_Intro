using System;

namespace c_sharp_course_udemy
{
    public class data_types
    {
       

        public static void Main(string[] args)
        {

            //Variables in C# do not interact directly with memory, they get initialized as 0 as default.
            //Variables are also initialized like python, can't use {} like in c++

            //Ints
            int age = 15; //int reaches 2^32
            long age2 = 12; //long is int as default
            short age3 = 12; //same as long, but reversed
            sbyte x = 120; //bytes are also stored as ints
            int unin_age; //Not initialized, it will be 0
            int age4 = 3, age5 = 4, age6 = 5; //Multi init is supported

            //floats
            float f = 3.3f; //you have to add the f, 7 digit precision, 2^38 
            double d = 3.3; //14 digit precision
            decimal dc = 3.3m; //28 digit precision, you have to use m at the end, just like float
            float unin_float; 


            //Strings, unlike c++, you don't have to import <string> and <iostream>
            char character = 'd'; //Declaration is with single quotes
            string str = "david"; //Declaration is with double quotes
            string str2 = "My name is " + str; //Can be concatented

            //Use writeline to add a \n at the end of the line, write to write normal.
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Age is: " + age2);
            Console.WriteLine("Age is: " + age3);
            Console.WriteLine("Age is: " + x );
            Console.WriteLine("Age is: " + f);
            Console.WriteLine("Age is: " + d);
            Console.WriteLine("Age is: " + dc);
            Console.WriteLine("Age is: " + character);
            Console.WriteLine("Age is: " + str);

            Console.Read(); //If you dont add this console won't display the writes.
        }

        public static void arithmetic_operations()
        {
            
        }
    }

}