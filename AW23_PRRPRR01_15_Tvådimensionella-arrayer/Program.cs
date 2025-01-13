using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_15_Tvådimensionella_arrayer {
	internal class Program {
		static void FillCellWithSumOfSurroundingCells(int[,] array, int x, int y) {
			int sum = 0;
			//sum += array[x + (-1), y + (-1)];
			//sum += array[x + 0, y + (-1)];
			//sum += array[x + 1, y + (-1)];
			//sum += array[x + 1, y + 0];
			//sum += array[x + 1, y + 1];
			//sum += array[x + 0, y + 1];
			//sum += array[x + (-1), y + 1];
			//sum += array[x + (-1), y + 0];

			for (int yOffset = -1; yOffset <= 1; yOffset++) {
				for (int xOffset = -1; xOffset <= 1; xOffset++) {
					if (yOffset == 0 && xOffset == 0) {
						continue; // hoppar över den här iterationen (körningen) av den inre for-loopen
					}
					if (x + xOffset < 0 || x + xOffset >= array.GetLength(0)
						|| y + yOffset < 0 || y + yOffset >= array.GetLength(1)) {

						continue;
					}

					sum += array[x + xOffset, y + yOffset];
				}
			}

			array[x, y] = sum;
		}

		static void Main(string[] args) {
			//int[,] myArray = new int[6, 5] {
			//	{ 7, 6, 5, 4, 3 },
			//	{ -3, -4, -5, -6, -7 },
			//	{ 15, 14, 13, 12, 11 },
			//	{ 28, 27, 26, 25, 24 },
			//	{ 99, 98, 97, 96, 95 },
			//	{ 0, -1, -2, -3, -4 }
			//};
			//myArray[0, 0] = 7;
			//myArray[1, 0] = -3;
			//myArray[2, 0] = 15;

			////for (int i = 0; i < myArray.Length; i++) {
			////	Console.WriteLine(myArray[i]);
			////}

			//for (int y = 0; y < myArray.GetLength(1); y++) {
			//	for (int x = 0; x < myArray.GetLength(0); x++) {
			//		Console.Write(myArray[x, y] + " ");
			//	}
			//	Console.WriteLine();
			//}

			////myArray[2, 3]

			int[,] array = new int[,] {
				{ 17, 67, 83, 9, 1337},
				{ 35, 42, 39, 97, 31 },
				{ 87, 27, 61, 76, 420 },
				{ -15, 2, 72, 84, 5 },
				{ 20, 1, 58, 69, 16 },
				{ 11, 94, 55, 18, 12 }
			};

			FillCellWithSumOfSurroundingCells(array, 2, 4);

			for (int y = 0; y < array.GetLength(1); y++) {
				for (int x = 0; x < array.GetLength(0); x++) {
					Console.Write(array[x, y] + " ");
				}
				Console.WriteLine();
			}

		}
	}
}
