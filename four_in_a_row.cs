
//Given a positive integer, tell whether it is equal to the
// sum of four consecutive integers.

using System;
class FourInARow{
	static void Main(string[] args){

		//Console.Write("Enter a postive integer: ");

		//int number  = int.Parse(Console.ReadLine());

		Console.WriteLine(IsEqual(18));
		Console.WriteLine(IsEqual(13));
		Console.WriteLine(IsEqual(2));
		Console.WriteLine(IsEqual(21));
		Console.WriteLine(IsEqual(22));
		
		

	}

	static bool IsEqual(int number){
		int middle = number/2;
		int smallest_middle = middle/2;
		int first_number = smallest_middle - 1;
		int biggest_middle = smallest_middle+1;
		int last_number = smallest_middle+2;

		/*if (first_number+smallest_middle+biggest_middle+last_number == number){
			return true;
		}else{
			return false;
		}*/

		//using ternary if
		number = first_number+smallest_middle+biggest_middle+last_number ? true : false
	}
}