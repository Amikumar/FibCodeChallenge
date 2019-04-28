using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibSequenceGenerator
{
	public static class FibSequence
	{
		/// <summary>
		/// Building on the principle of a Fibonacci sequence, create a function that takes a signature of x elements 
		/// and calculates each new value in the sequence 
		/// using the sum of the last x elements and returns the first n elements.
		/// </summary>
		/// <param name="inputSequence">signature of x elements </param>
		/// <param name="number">No of elements needs to generated</param>
		/// <returns>Generated list based on sum of the last x elements and returns the first n elements</returns>
		public static List<int> GenerateFibSequence(List<int> inputSequence, int number)
		{
			int inputSeqLength = inputSequence.Count;
			//We are using starPointer on array .it will point to element in array to start the sum 
			// and end pointer will be array length
			//The purpose is to use the same to sum of last x elements
			// After each iteration we are going to increment
			int startPointer = 0;
			for (int i = inputSeqLength; i < number; i++)
			{
				int sum = 0;
				for (int j = i - 1; j >= startPointer; j--)
				{
					//2,1,0
					sum = sum + inputSequence[j];
				}
				inputSequence.Add(sum);
				startPointer++;

			}
			return inputSequence;
		}
	}
}
