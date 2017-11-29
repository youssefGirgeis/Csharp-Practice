
/*
Your goal is to implement an difference function, which subtracts one list from another.
It should remove all values from list a, which are present in list b.
Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
If a value is present in b, all of its occurrences must be removed from the other:
ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1,3}
*/

using System;
using System.Collections.Generic;
using System.Linq;
class ArrayDiff{
	static void Main(string[] args){

		Array_Diff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 });
	
	}

	static int[] Array_Diff(int[] a, int[] b)
	{
		 List<int> finalList = new List<int>();

            foreach(int i in a)
            {
                if (!b.Contains(i))
                {
                    finalList.Add(i);
                }
            }

            return finalList.ToArray(); 

		

	}
}