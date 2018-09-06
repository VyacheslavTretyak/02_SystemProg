namespace EncryptionFile
{
	partial class EncryptionFile
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lFileName = new System.Windows.Forms.Label();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.progBar = new System.Windows.Forms.ProgressBar();
			this.numeric = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
			this.SuspendLayout();
			// 
			// lFileName
			// 
			this.lFileName.AutoSize = true;
			this.lFileName.Location = new System.Drawing.Point(13, 13);
			this.lFileName.Name = "lFileName";
			this.lFileName.Size = new System.Drawing.Size(126, 13);
			this.lFileName.TabIndex = 0;
			this.lFileName.Text = "Choose file for encryption";
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(12, 39);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 1;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// progBar
			// 
			this.progBar.Location = new System.Drawing.Point(16, 196);
			this.progBar.Name = "progBar";
			this.progBar.Size = new System.Drawing.Size(356, 23);
			this.progBar.TabIndex = 2;
			// 
			// numeric
			// 
			this.numeric.Location = new System.Drawing.Point(16, 131);
			this.numeric.Maximum = new decimal(new int[] {
            524288,
            0,
            0,
            0});
			this.numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numeric.Name = "numeric";
			this.numeric.Size = new System.Drawing.Size(120, 20);
			this.numeric.TabIndex = 3;
			this.numeric.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			// 
			// btnStart
			// 
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(16, 167);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(293, 167);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(13, 98);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(355, 20);
			this.textBox1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Key for encryption";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// EncryptionFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 240);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.numeric);
			this.Controls.Add(this.progBar);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.lFileName);
			this.Name = "EncryptionFile";
			this.Text = "EncryptionFile";
			((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lFileName;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.ProgressBar progBar;
		private System.Windows.Forms.NumericUpDown numeric;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

