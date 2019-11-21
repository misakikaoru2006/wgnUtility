using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wgnUtility{
    static class Program    {
		private static System.Threading.Mutex _mutex;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)        {
#if DEGUB
#else
            try            {
#endif
				//Mutexクラスの作成
				_mutex = new System.Threading.Mutex(false, "wgnUtility");
				//ミューテックスの所有権を要求する
				if (_mutex.WaitOne(0, false)) {
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Form1());
				}
				else {
					//すでに起動していると判断して終了
					//MessageBox.Show("多重起動はできません。");
					return;
				}
#if DEGUB
#else
            }
            catch (Exception exception)            {
				string error = exception.Message;
            }
#endif            
        }
    }
}
