using System.IO;
using System.Windows.Forms;

namespace wgnUtility
{
	public partial class Form1 {
		string wgndriveRoot = @"J:\";
		string wgnImport = @"IMPORT";//PC2WG-10
		string wgnExport = @"EXPORT";//WG-10_2pc
		string datapathRoot = Path.GetDirectoryName(Application.ExecutablePath) + @"\";
		private void wgn10() {
			fixWGNdisk();
			roottextBox.Text = wgndriveRoot + wgnExport;
			//datapathRootとの整合性を保つ。★2013年01月05日(土)
			argstargetbox.Text = datapathRoot;
			//BMPを振り分け。
			File2Date(wgndriveRoot + wgnExport, "*.bmp", datapathRoot, "Sharp WG-N10手書きメモ", ".png");
			saveText2wgn10();
		}

		private void fixWGNdisk() {
			string drives = "defghijklmnopqrstuvwxwz";
			foreach (char c in drives) {
				string drivepath = c.ToString() + @":\";
				if (Directory.Exists(drivepath + wgnExport) && Directory.Exists(drivepath + wgnImport)) {
					wgndriveRoot = drivepath;
					roottextBox.Text = wgndriveRoot + wgnExport;
					break;
				}
			}
		}
	}
}