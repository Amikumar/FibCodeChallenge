using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibSequenceGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputSeqArray = new List<int> { 1,1 };
			var n = 6;
			var result= FibSequence.GenerateFibSequence(inputSeqArray, n);
			Console.WriteLine("Output for input sequence {1, 1 } n=6 ={" + string.Join(",", result) + " }");
			inputSeqArray = new List<int> { 0, 1, 1 };
			 n = 10;
			result = FibSequence.GenerateFibSequence(inputSeqArray, n);
			Console.WriteLine("Output for input sequence { 0, 1, 1 } n=10 ={"+ string.Join(",", result)+" }");
			inputSeqArray = new List<int> { 2, 4, 6, 8 };
			n = 12;
			result = FibSequence.GenerateFibSequence(inputSeqArray, n);
			Console.WriteLine("Output for input sequence {2, 4, 6, 8  } n=12 ={" + string.Join(",", result) + " }");
			Console.Read();
		}
		
	}
}
