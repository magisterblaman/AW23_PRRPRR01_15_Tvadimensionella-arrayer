using Pastel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlTypes;

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

		static void MakeGrayscale(Color[,] image) {
			for (int y = 0; y < image.GetLength(1); y++) {
				for (int x = 0; x < image.GetLength(0); x++) {
					Color oldColor = image[x, y];

					int average = (oldColor.R + oldColor.G + oldColor.B) / 3;

					Color newColor = Color.FromArgb(oldColor.A, average, average, average);

					image[x, y] = newColor;
				}
			}
		}

		static Color[,] Rotate90DegClockwise(Color[,] source) {
			Color[,] target = new Color[source.GetLength(1), source.GetLength(0)];

			for (int y = 0; y < target.GetLength(1); y++) {
				for (int x = 0; x < target.GetLength(0); x++) {
					target[x, y] = source[y, source.GetLength(1) - 1 - x];
				}
			}

			return target;
		}

		static void Main(string[] args) {
			//Console.WriteLine("Hejsan svejsan".PastelBg(Color.FromArgb(23, 98, 213)));

			Color[,] image = ImageHandler.LoadImage("diamond_pickaxe.png");

			MakeGrayscale(image);

			Color[,] rotated = Rotate90DegClockwise(image);

			for (int y = 0; y < rotated.GetLength(1); y++) {
				for (int x = 0; x < rotated.GetLength(0); x++) {
					Console.Write(" ".PastelBg(rotated[x, y]));
				}
				Console.WriteLine();
			}
		}
	}
}
