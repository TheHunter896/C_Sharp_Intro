using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsCourseUdemy
{
    class arrays
    {
        public void arraysMain()
        {
           
            //Lists
            //Lists are contiguous indefinite allocation. Use () after list to say which size, use {} to initialize values 
            List<int> example = new List<int>() { }; //Use a capacity integers in parathesis, dont use it to have unlimited
            example.Add(1);
            example[1] = 2;
            example[2] = 1;

            //You can also declare generic type arrays lists
            var generic = new List<string>() { };

            //Arraylists
            //You can also declare lists like so, but this is depracated
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("Hi");
            //When looping we should use var or object.

            //Arrays
            //You can basically declare arrays with a dataType and specifying the array after -> int[] intArray;
            //int[] name = [initialization]
            //int[] name = {1, 2, 3, 4, 5}
            //int[] name = new int[4]; -> Initializes 4 spaces, empty
            //If you want to add values to the previous initialization remember that it has to have the same length
            //int[] name = new int[4] { 1, 2, 3, 4 }; -> allocation and init are the same length

            //Multidimensional arrays are also supported
            int[,] arrayName = new int[,] { { }, { } }; // 1 comma, 2d, 2 commas, 3d, etc.
            //You can initialize it like in C++
            int[,] multiArray = new int[,]
            {
                { },
                { },
            };
            //To access it
            multiArray[0, 0] = 1; //Element 0, 0

            //You can also specify multi dim arrays like so
            string[,] array2D = new string[3, 2];

            //A jagged array is a multi dimensional arrays where the arrays inside can be different sizes, in the previous example they are all the same size.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
        }

        //Arrays are non generic (tuples in python)
        //ArrayLists the depcrataded lists
        //Lists are generic and you dont have to specify the length (lists in python)

    }
}
