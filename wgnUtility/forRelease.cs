using System;
using System.Windows.Forms;

namespace wgnUtility
{
	public partial class Form1 : Form{
        string[] args = Environment.GetCommandLineArgs();
        public void releaseinitial(){
  
		}
		private void formloadsetting() {
			roottextBox.Text = Properties.Settings.Default.path;
			argstargetbox.Text = Properties.Settings.Default.Target;
		}


		private void saveproperties() {
			Properties.Settings.Default.path = roottextBox.Text;
			Properties.Settings.Default.Target = argstargetbox.Text;
			Properties.Settings.Default.Save();
		}


        string Target = Properties.Settings.Default.Target.ToString();
        string path = Properties.Settings.Default.path.ToString();
        int width = Properties.Settings.Default.width;
		int height = Properties.Settings.Default.height;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)        {
            // Ctrl + E をボタンのショートカットキーとして処理する
            if ((int)keyData == (int)Keys.Control + (int)Keys.E ||
                (int)keyData == (int)Keys.Control + (int)Keys.Q)            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)        {
            Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        string domain = Environment.UserDomainName; // ドメイン名=マシン名
        string username = Environment.UserName;
        private void execute_Click(object sender, EventArgs e)        {
			execute.Enabled = false;
			wgn10();
			execute.Enabled = true;
        }
    }
}
