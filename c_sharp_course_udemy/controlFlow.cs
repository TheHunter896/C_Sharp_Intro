using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CsCourseUdemy
{
    class ControlFlow
    {
        public void ControlFlowStatements()
        {
            //Basically all options as in c++ are avaliable
            int num = 1;
            if (num == 0)
            {
                //Do something
            }
            else if (num == 1)
            {
                //Do something else if
            }
            else
            {
                //Do something else if none is matched
            }

            //0 is false, 1 is true;
            //Same goes for arrays
            int[] array = { 1, 2, 3, 4, 5 };

            if (array.Length > 0)
            {
                //Do something
            }

            //Try and catch + finally
            //Can be chained, but take care of what do you put where, since some exceptions englobe others, works exactly like if else statement. Finally gets executed after any kind of catch or try.
            try
            {
                //Try to do something
            }
            catch (SyntaxErrorException) {
                //Something failed, specify exception
            }
            catch (Exception)
            {
                //Catch another exception
            }
            finally
            {
                //Do something
            }

            //Switch statement is supported
            switch (num) //Numeric if statement
            {
                case 1:
                    //Do something
                    break;

                case 2:
                    break;
                default:
                    break; //You need break in default in c#
            }

            //Nested if statements (of course) are supported
            //Ternary statements are also supported

            //Variable = condition ? true:false;
            bool isNumWithinParameters = num > 0 ? true : false; //You can return any type here, doesnt have to be boolean
            if (isNumWithinParameters)
            {
                //Do something
            }
        }

        public void controlFlowLoops()
        {
            int num1 = 0;
            //For loops
            // for(start value; condition; increment/decrement){}
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //While loops
            // while(condition){}
            while(num1 < 10)
            {
                Console.WriteLine(num1);
                num1++;
            }

            //Do while
            //do {} while(condition)
            do
            {
                Console.WriteLine(num1);
                num1++;
            } while (num1 < 10);

            //Break and continue are supported

            int[] arr = new int[4] { 1, 2, 3, 4 };

            //ForEach is supporteddd!!!!! Using var, which is a general type, can be anything
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            //Curiously loops can also hold literals ascii values, which makes sense
            for(char column ='a'; column < 'k'; column++)
            {
                Console.WriteLine(column);
            }


            

        }
       
    }
}
