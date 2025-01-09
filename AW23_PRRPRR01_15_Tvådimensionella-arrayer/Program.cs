using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_15_Tvådimensionella_arrayer {
	internal class Program {
		static void Main(string[] args) {
			int[,] myArray = new int[6, 5] {
				{ 7, 6, 5, 4, 3 },
				{ -3, -4, -5, -6, -7 },
				{ 15, 14, 13, 12, 11 },
				{ 28, 27, 26, 25, 24 },
				{ 99, 98, 97, 96, 95 },
				{ 0, -1, -2, -3, -4 }
			};
			myArray[0, 0] = 7;
			myArray[1, 0] = -3;
			myArray[2, 0] = 15;

			//for (int i = 0; i < myArray.Length; i++) {
			//	Console.WriteLine(myArray[i]);
			//}

			for (int y = 0; y < myArray.GetLength(1); y++) {
				for (int x = 0; x < myArray.GetLength(0); x++) {
					Console.Write(myArray[x, y] + " ");
				}
				Console.WriteLine();
			}

			//myArray[2, 3]
		}
	}
}
