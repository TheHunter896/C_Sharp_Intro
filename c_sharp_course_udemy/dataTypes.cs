using System;
using System.Linq;

namespace CsCourseUdemy
{   
    public class DataTypes
    {
       

        public static void Main(string[] args)
        {

            //Variables in C# do not interact directly with memory, they get initialized as 0 as default.
            //Variables are also initialized like python, can't use {} like in c++
            //However the reference is still accessible.

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

            string ascii_x = Console.ReadLine(); //Returns the ascii reference of what is typed
            //Use int variable + Read to get the string value in ASCII
            //Use string + ReadLine to get the actual value in string (of wha the user inputs)
            Console.WriteLine(ascii_x);
        }

        public static void VariableConversion()
        {
            double myDouble = 13.38;
            int myInt;

            //Explicit conversion
            //Cannot asign directly to int, need round/ceil, or cast
            //Use C-Like conversion to change data types between numbers
            myInt = (int)myDouble; //As you can see this is how it's done in C, in C++ we would use a static_cast() function

            int num = 1323435;
            long bigNum = num; //Implicit conversion in the value of num
            
            //From int/double/float/decimal to string
            //use methods to change from number to string
            int num2 = 3;
            string num2String = num2.ToString();
            // string num2String2 = (string)num2; //Cannot use C-Like conversion

            //From string to number, use this with the according class you want to transform to
            string stringToInt = "14";
            int parsedInt = Int32.Parse(stringToInt);

        }

        public static void stringMethods()
        {
            string exampleString = "David";
            exampleString.ToLower();
            exampleString.ToUpper();
            exampleString.IndexOf('d');
            exampleString.Substring(0, 1);
            String.Format(exampleString, "replacement"); //The string needs a {} with the index to be reformatted

        }   
    }

}