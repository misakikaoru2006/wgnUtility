using System;
using System.Collections.Generic;
using System.Drawing;   //画像処理のため。2010/11/17(水)
using System.IO;

namespace wgnUtility
{
	public partial class Form1
	{
		/// <summary>
		/// bmpをWG-N10からgetしてファイルの日付で振り分けする。
		/// </summary>
		/// <param name="path"></param>
		/// <param name="extension"></param>
		/// <param name="saveroot"></param>
		/// <param name="comment"></param>
		/// <param name="newextension"></param>
		/// <returns></returns>
		public string File2Date(string path, string extension, string saveroot, string comment, string newextension)
		{
			//datapathRootとの整合性を保つ。★2013年01月05日(土)
			if (saveroot != argstargetbox.Text)
			{
				if (Directory.Exists(argstargetbox.Text))
					saveroot = argstargetbox.Text;
				if (!saveroot.EndsWith(@"\")) saveroot += @"\";
				datapathRoot = saveroot;
			}

			var files = new List<string>(Directory.GetFiles(path, extension));
			foreach (string file in files)
			{
				DateTime writedt = File.GetLastWriteTime(file);
				//その日のフォルダを作る。
				string target = "";
				target = saveroot + writedt.ToString("yyyy_MMdd/");
				createDirectoryifnotExists(target);
				string saveName = target + comment + writedt.ToString("yyyy_MMdd_HHmm_ss") + newextension;
				if (!File.Exists(saveName)) bmp2png(file, saveName);
			}
			return files.Count + "件を処理終了しました。";
		}

		private void bmp2png(string importFile, string newFile)
		{
			Bitmap bitmap = new Bitmap(importFile);
			bitmap.Save(newFile, System.Drawing.Imaging.ImageFormat.Png);
			bitmap.Dispose();
			File.Delete(importFile);
		}

		public void createDirectoryifnotExists(string path)
		{
			try
			{
				if (!Directory.Exists(path)) Directory.CreateDirectory(path);
			}
			catch (Exception exception)
			{
			}
		}
	}
}