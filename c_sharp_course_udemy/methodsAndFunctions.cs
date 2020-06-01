using System;
using System.Collections.Generic;
using System.Text;

namespace CsCourseUdemy
{
    class FunctionsAndMethods
    {
        public void method1()  //Parameters need types
        {
            //Methods work exactly like C++, but they don't need all the implementation that C++ does with .h and .cpp
            //Which makes it a little bit clearer, but more clustered in the cs files

            //The structure is [accessType] [static] returnType methodName (parameterList)
            //Static is basically the cls in Python, does not belong to an instance, but the whole class definition.
        }

        public void UserAdd()
        {

            //Really explicit code
            string num1;
            string num2;

            Console.WriteLine("Enter a first number: ");
            num1 = Console.ReadLine();
            Console.WriteLine("Enter a second number: ");
            num2 = Console.ReadLine();

            int num1Int = Int32.Parse(num1);
            int num2Int = Int32.Parse(num2);

            Console.WriteLine("The result is " + (num1Int + num2Int));
        }
    }
}
