using System.IO;
using System.Text;
using System.Windows.Forms;

namespace wgnUtility
{
	public partial class Form1 : Form
	{
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] dragFilePathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			foreach (string dragFilePath in dragFilePathArray)
			{
				//ファイルの場合。
				if (File.Exists(dragFilePath))
				{
					roottextBox.Text = Path.GetDirectoryName(dragFilePath);
					if (dragFilePath.EndsWith(".txt"))
						reportBox.Text = File.ReadAllText(dragFilePath, Encoding.GetEncoding("Shift_JIS"));
				}
				//フォルダの場合。
				else if (Directory.Exists(dragFilePath)) roottextBox.Text = dragFilePath;
			}
			path = roottextBox.Text;
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
			else if (e.Data.GetDataPresent("UniformResourceLocator") || e.Data.GetDataPresent("UniformResourceLocatorW")) e.Effect = DragDropEffects.Link;
			else if (e.Data.GetDataPresent("Text")) e.Effect = DragDropEffects.All;
			else e.Effect = DragDropEffects.None;
		}

		private void textBox3_DragDrop(object sender, DragEventArgs e)
		{
			string[] dragFilePathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			foreach (string dragFilePath in dragFilePathArray)
			{
				//ファイルの場合。
				if (File.Exists(dragFilePath)) argstargetbox.Text = Path.GetDirectoryName(dragFilePath);
				//フォルダの場合。
				else if (Directory.Exists(dragFilePath)) argstargetbox.Text = dragFilePath;
			}
		}
	}
}