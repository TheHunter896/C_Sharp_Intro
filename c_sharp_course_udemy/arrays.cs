using System;
using System.Collections.Generic;
using System.Text;

namespace CsCourseUdemy
{
    class arrays
    {
        public void arraysMain()
        {
            //You can basically declare arrays with a dataType and specifying the array after -> int[] intArray;
            //int[] name = [initialization]
            //int[] name = {1, 2, 3, 4, 5}
            //int[] name = new int[4]; -> Initializes 4 spaces, empty
            //If you want to add values to the previous initialization remember that it has to have the same length
            //int[] name = new int[4] { 1, 2, 3, 4 }; -> allocation and init are the same length

            //Lists
            //Lists are contiguous indefinite allocation. Use () after list to say which size, use {} to initialize values 
            List<int> example = new List<int>() { }; //Use a capacity integers in parathesis, dont use it to have unlimited
            example.Add(1);
            example[1] = 2;
            example[2] = 1;

            //You can also declare generic type arrays lists
            var generic = new List<string>() { };

            //Multidimensional arrays are also supported
            int[,,] arrayName = new int[,,] { };
            //You can initialize it like in C++
            int[,,] multiArray = new int[,,]
            {
                {
                    { }
                },
                {
                    { }
                }
            };

        }

    }
}
