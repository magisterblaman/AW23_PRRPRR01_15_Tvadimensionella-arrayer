using System.Drawing;

namespace AW23_PRRPRR01_15_Tvådimensionella_arrayer {
	public static class ImageHandler {
		/// <summary>
		/// Laddar in en bild som en tvådimensionell array av färger.
		/// </summary>
		/// <param name="fileName">Sökvägen till filen.</param>
		/// <returns>Bilden som en tvådimensionell array av färger.</returns>
		public static Color[,] LoadImage(string fileName) {
			Bitmap bitmap = new Bitmap(fileName);

			Color[,] image = new Color[bitmap.Width, bitmap.Height];

			for (int y = 0; y < image.GetLength(1); y++) {
				for (int x = 0; x < image.GetLength(0); x++) {
					image[x, y] = bitmap.GetPixel(x, y);
				}
			}

			return image;
		}

		/// <summary>
		/// Sparar en bild.
		/// </summary>
		/// <param name="fileName">Sökvägen till filen.</param>
		/// <param name="image">Bilden som en tvådimensionell array av färger.</param>
		public static void SaveImage(string fileName, Color[,] image) {
			Bitmap bitmap = new Bitmap(image.GetLength(0), image.GetLength(1));

			for (int y = 0; y < image.GetLength(1); y++) {
				for (int x = 0; x < image.GetLength(0); x++) {
					bitmap.SetPixel(x, y, image[x, y]);
				}
			}

			bitmap.Save(fileName);
		}
	}
}
