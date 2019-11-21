using System;
using System.Drawing;   //画像処理のため。2010/11/17(水)
using System.IO;
using System.Text;

namespace wgnUtility
{
	public partial class Form1 {
		private void saveText2wgn10() {
			var textpath = datapathRoot + "todo.txt";
			//書き込む文字の内容
			var todo = File.Exists(textpath) ? File.ReadAllText(textpath, Encoding.GetEncoding("Shift_JIS")) : reportBox.Text;
			var font = new Font("Meiryo", 28);
			SaveBMP(todo, font);
		}

		private void SaveBMP(string text, Font font) {
			//テンプレート読み込み
			var path = datapathRoot + "color.png";
			//Bitmapオブジェクトの生成 
			using (var bmp = new Bitmap(path)) {
				//解像度の設定
				bmp.SetResolution(72, 72);
				//Graphicsオブジェクトを取得   
				using (Graphics g = Graphics.FromImage(bmp)) {
					//画像を描画する   
					g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
					//ブラシを作成する   
					using (var brush = new SolidBrush(System.Drawing.Color.Black)) {
						//文字の領域サイズを取得する
						var format = new StringFormat();
						var fontSize = g.MeasureString(text, font, bmp.Width, format);
						var rectangle = new RectangleF(10, 10, bmp.Width-20, bmp.Height-20);
						//文字を描画する
						//g.DrawString(text, font, brush, (bmp.Width / 2) - (fontSize.Width / 2), (bmp.Height / 2) - (fontSize.Height / 2));//開始位置のみ
						g.DrawString(text, font, brush, rectangle);//regtangle内に描画
						//https://docs.microsoft.com/ja-jp/dotnet/framework/winforms/advanced/how-to-draw-wrapped-text-in-a-rectangle
					}
				}
				var tmp = wgndriveRoot + wgnImport + @"\"+ DateTime.Now.ToString("yyyy_MMdd_HHmm");
				try {
					Bitmap gray = color2Gray.color2gray.BitmapToGrayscale4bpp(bmp);
					gray.Save(tmp + "gray.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
				}
				catch (Exception exception) {
					var error = exception.Message;
				}
			}
		}
	}
}