using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public bool enemyTalk = false;

    void Update()
    {
        if (enemyTalk == true)
        {
            print("Mr Stark I dont feel so good...");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimPractise
{
    class Sorting_Algorithim //After getting a sorted array with PidgeonHole Sort it holds a Time complexity of O (n+Range)
    {
        public static void PigeonHole_Sort(int[] array, int n) // take an array  & indicator for # of elements (length)
        {
            int min = array[0];
            int max = array[0];
            int range, i, j, index;

            for (int x = 0; x < n; x++) // forloop to go through all the elements in the array to find the max & min
            {
                if (array[x] > max)
                {
                    max = array[x]; // setting max value = 8
                }
                if (array[x] < min)
                {
                    min = array[x]; // setting min value = 2
                }
            }

            range = max - min + 1; //finding range value with this formula max - min + 1 ... range = 7 here

            int[] phole = new int[range]; // setting the int for pholes to the range value

            for (i = 0; i < n; i++) //Pigeon hole indicator column
            {
                phole[i] = 0; // setting all pigeon holes to empty //Initializing empty pigeon holes with the range size
            }

            for (i = 0; i < n; i++)
            { 
                phole[array[i] - min]++; // this places elements into the pidgeon holes examples below
            }// ++ PLUS PLUS MOVES TO THE NEXT PIDGEON HOLE
            //first element test
            // array i - min ... 8i - 2 = 6 ... phole[6]++ ... phole[7] ... phole[7] means 6th element in the pidgeon hole array (thats why add 1)
            // not sure yet but phole[6]++ means the i (in this case 8) will be placed in phole 6
            //second element test
            // array i - min ... 3i - 2 = 1 ... phole[1]++ ... phole[2] ... phole[2] means 1st element in the pidgeon hole array (thats why add 1)
            // not sure yet but phole[1]++ means the i (in this case 3) will be placed in phole 1
            // so the colume would look like 
            // 0 ( )
            // 1 (3)
            // 2 ( )
            // 3 ( )
            // 4 ( )
            // 5 ( )
            // 6 (8) // since there is 2 8's they both will go in #6 this is the special thing about Pidegon Hole Sorting so technically it would be 6 (8, 8) in the output it will also come out as 8 8 at the end.

            index = 0; // index for the input data / array

            // now copying the elements from the pidgeon holes to the original array
            for (j = 0; j < range; j++) 
            {
                while(phole[j] --> 0)
                {
                    array[index++] = j + min;
                }
            }
        }

        static void Main()
        {
            int[] array = { 8, 3, 2, 7, 4, 6, 8 }; // input data

            Console.Write("Sorted order is: ");

            PigeonHole_Sort(array, array.Length); // run the PHS function

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The # of elements in this array is : " + array.Length);
            Console.ReadLine(); 
        }
            
    }
}


/*
 // C# program to implement 
// Pigeonhole Sort 
using System; 

class GFG 
{ 
public static void pigeonhole_sort(int []arr, 
								int n) 
{ 
	int min = arr[0]; 
	int max = arr[0]; 
	int range, i, j, index; 

	for(int a = 0; a < n; a++) 
	{ 
		if(arr[a] > max) 
			max = arr[a]; 
		if(arr[a] < min) 
			min = arr[a]; 
	} 

	range = max - min + 1; 
	int[] phole = new int[range]; 
	
	for(i = 0; i < n; i++) 
	phole[i] = 0; 

	for(i = 0; i < n; i++) 
		phole[arr[i] - min]++; 

	
	index = 0; 

	for(j = 0; j < range; j++) 
		while(phole[j] --> 0) 
			arr[index++] = j + min; 

} 

// Driver Code 
static void Main() 
{ 
	int[] arr = {8, 3, 2, 7, 
				4, 6, 8}; 

	Console.Write("Sorted order is : "); 

	pigeonhole_sort(arr,arr.Length); 
	
	for(int i = 0 ; i < arr.Length ; i++) 
		Console.Write(arr[i] + " "); 
} 
} 

// This code is contributed 
// by Sam007 

*/
