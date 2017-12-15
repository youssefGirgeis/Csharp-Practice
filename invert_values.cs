//Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

using System;

  public static class ArraysInversion
  {
  		static void Main(string[] args){

		Console.WriteLine(InvertValues([1,2,3,4,5]));
	
		}

    public static int[] InvertValues(int[] input)
    {
    	int [] inverted_array = new int[input.Length];
      	for(int i =0; i<input.Length; i++)
      	{
      		int inverted_number = input[i] - (input[i]*2);
      		inverted_array[i] = inverted_number;
      	}

      	return inverted_array;
    }
  }
