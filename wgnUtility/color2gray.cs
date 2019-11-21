using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace color2Gray {
	class color2gray {
		//カラービットマップを32bitグレースケールに減色する。★2013年01月05日(土)
		public static Bitmap convert2Grayscale(Bitmap original) {
			//create a blank bitmap the same size as original
			Bitmap newBitmap = new Bitmap(original.Width, original.Height);
			//get a graphics object from the new image
			Graphics g = Graphics.FromImage(newBitmap);
			//create the grayscale ColorMatrix
			ColorMatrix colorMatrix = new ColorMatrix(
			   new float[][]       {
				  new float[] {.3f, .3f, .3f, 0, 0},
				  new float[] {.59f, .59f, .59f, 0, 0},
				  new float[] {.11f, .11f, .11f, 0, 0},
				  new float[] {0, 0, 0, 1, 0},
				  new float[] {0, 0, 0, 0, 1}
			   });

			//create some image attributes
			ImageAttributes attributes = new ImageAttributes();
			//set the color matrix attribute
			attributes.SetColorMatrix(colorMatrix);
			//draw the original image on the new image
			//using the grayscale color matrix
			g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
			   0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

			//dispose the Graphics object
			g.Dispose();
			return newBitmap;
		}

		//カラービットマップを4bitグレースケールに減色する。★2013年01月05日(土)
		public static Bitmap BitmapToGrayscale4bpp(Bitmap source) {
			// Create target image.
			int width = source.Width;
			int height = source.Height;
			Bitmap target = new Bitmap(width, height, PixelFormat.Format4bppIndexed);
			// Set the palette to discrete shades of gray
			ColorPalette palette = target.Palette;
			for (int i = 0; i < palette.Entries.Length; i++) {
				int cval = 17 * i;
				palette.Entries[i] = Color.FromArgb(0, cval, cval, cval);
			}
			target.Palette = palette;

			// Lock bits so we have direct access to bitmap data
			BitmapData targetData = target.LockBits(new Rectangle(0, 0, width, height),
													ImageLockMode.ReadWrite, PixelFormat.Format4bppIndexed);
			BitmapData sourceData = source.LockBits(new Rectangle(0, 0, width, height),
													ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

			unsafe {//Visual Studio 開発環境でこのコンパイラ オプションを設定するには 1.プロジェクトの [プロパティ] ページを開きます。2.[ビルド] プロパティ ページをクリックします。3.[アンセーフ コードの許可] チェック ボックスをオンにします。

				for (int r = 0; r < height; r++) {
					byte* pTarget = (byte*)(targetData.Scan0 + r * targetData.Stride);
					byte* pSource = (byte*)(sourceData.Scan0 + r * sourceData.Stride);
					byte prevValue = 0;
					for (int c = 0; c < width; c++) {
						byte colorIndex = (byte)((((*pSource) * 0.3 + *(pSource + 1) * 0.59 + *(pSource + 2) * 0.11)) / 16);
						if (c % 2 == 0)
							prevValue = colorIndex;
						else
							*(pTarget++) = (byte)(prevValue | colorIndex << 4);

						pSource += 3;
					}
				}
			}

			target.UnlockBits(targetData);
			source.UnlockBits(sourceData);
			return target;
			//http://stackoverflow.com/questions/2703947/reducing-bitmap-bit-size-in-c-sharp
		}
	}
}
