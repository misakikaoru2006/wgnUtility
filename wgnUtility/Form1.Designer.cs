namespace wgnUtility
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.execute = new System.Windows.Forms.Button();
			this.roottextBox = new System.Windows.Forms.TextBox();
			this.reportBox = new System.Windows.Forms.TextBox();
			this.startsoon = new System.Windows.Forms.CheckBox();
			this.argsTargetlabel = new System.Windows.Forms.Label();
			this.argstargetbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "root path";
			// 
			// execute
			// 
			this.execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.execute.Location = new System.Drawing.Point(714, 385);
			this.execute.Name = "execute";
			this.execute.Size = new System.Drawing.Size(57, 23);
			this.execute.TabIndex = 2;
			this.execute.Text = "execute";
			this.execute.UseVisualStyleBackColor = true;
			this.execute.Click += new System.EventHandler(this.execute_Click);
			// 
			// roottextBox
			// 
			this.roottextBox.AllowDrop = true;
			this.roottextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.roottextBox.Location = new System.Drawing.Point(117, 12);
			this.roottextBox.Name = "roottextBox";
			this.roottextBox.Size = new System.Drawing.Size(654, 19);
			this.roottextBox.TabIndex = 3;
			this.roottextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.roottextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// reportBox
			// 
			this.reportBox.AcceptsReturn = true;
			this.reportBox.AcceptsTab = true;
			this.reportBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reportBox.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.reportBox.Location = new System.Drawing.Point(-1, 59);
			this.reportBox.Multiline = true;
			this.reportBox.Name = "reportBox";
			this.reportBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.reportBox.Size = new System.Drawing.Size(789, 310);
			this.reportBox.TabIndex = 10;
			// 
			// startsoon
			// 
			this.startsoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startsoon.AutoSize = true;
			this.startsoon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.startsoon.Location = new System.Drawing.Point(566, 323);
			this.startsoon.Name = "startsoon";
			this.startsoon.Size = new System.Drawing.Size(166, 19);
			this.startsoon.TabIndex = 5;
			this.startsoon.Text = "execute soon when args";
			this.startsoon.UseVisualStyleBackColor = true;
			// 
			// argsTargetlabel
			// 
			this.argsTargetlabel.AutoSize = true;
			this.argsTargetlabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.argsTargetlabel.Location = new System.Drawing.Point(12, 39);
			this.argsTargetlabel.Name = "argsTargetlabel";
			this.argsTargetlabel.Size = new System.Drawing.Size(80, 17);
			this.argsTargetlabel.TabIndex = 6;
			this.argsTargetlabel.Text = "target path";
			// 
			// argstargetbox
			// 
			this.argstargetbox.AllowDrop = true;
			this.argstargetbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.argstargetbox.Location = new System.Drawing.Point(117, 37);
			this.argstargetbox.Name = "argstargetbox";
			this.argstargetbox.Size = new System.Drawing.Size(654, 19);
			this.argstargetbox.TabIndex = 7;
			this.argstargetbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox3_DragDrop);
			this.argstargetbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			// 
			// Form1
			// 
			this.AcceptButton = this.execute;
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 420);
			this.Controls.Add(this.argstargetbox);
			this.Controls.Add(this.argsTargetlabel);
			this.Controls.Add(this.reportBox);
			this.Controls.Add(this.startsoon);
			this.Controls.Add(this.execute);
			this.Controls.Add(this.roottextBox);
			this.Controls.Add(this.label1);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::wgnUtility.Properties.Settings.Default, "MyLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = global::wgnUtility.Properties.Settings.Default.MyLocation;
			this.Name = "Form1";
			this.ShowInTaskbar = false;
			this.Text = "wgnUtility";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.TextBox roottextBox;
        private System.Windows.Forms.TextBox reportBox;
        private System.Windows.Forms.CheckBox startsoon;
		private System.Windows.Forms.Label argsTargetlabel;
		private System.Windows.Forms.TextBox argstargetbox;


    }
}

