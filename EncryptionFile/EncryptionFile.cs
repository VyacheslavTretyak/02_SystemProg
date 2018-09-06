using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionFile
{
	
	public partial class EncryptionFile : Form
	{
		private delegate void updateProgressBar(int val);
		private delegate void btnStartEnable(bool val);
		private delegate void btnCancelEnable(bool val);
		private FileStream fileStream = null;
		private Thread threadEncrypting;
		private Thread threadDecrypting;
		private Data data = null;
		private string FileName { get; set; }
		public EncryptionFile()
		{
			InitializeComponent();
			btnOpenFile.Click += BtnOpenFile_Click;
			btnStart.Click += BtnStart_Click;
			btnCancel.Click += BtnCancel_Click;
			textBox1.TextChanged += TextBox1_TextChanged;
			progBar.Minimum = 0;
			progBar.Maximum = 100;
			numeric.Value = 128;
			textBox1.Text = "";
			data = new Data();
			progBar.MouseMove += ProgBar_MouseMove;
			
		}

		private void ProgBar_MouseMove(object sender, MouseEventArgs e)
		{
			toolTip1.Show($"{data.Speed} Kb/sec", progBar);

		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{							
			btnStart.Enabled = true;
			btnCancel.Enabled = false;
			threadEncrypting.Abort();			
			threadDecrypting = new Thread(new ParameterizedThreadStart(Encrypting));
			threadDecrypting.Start(data);
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			TextBox tb = sender as TextBox;
			if(tb.Text.Length >= 6)
			{
				btnStart.Enabled = true;
			}
			else
			{
				btnStart.Enabled = false;
			}
		}

		
		private void ProgressBarUpdate(int val)
		{			
			progBar.Value = val;
		}
		private void BtnStartEnable(bool val)
		{
			btnStart.Enabled = val;
		}
		private void BtnCancelEnable(bool val)
		{
			btnCancel.Enabled = val;
		}
		private void BtnStart_Click(object sender, EventArgs e)
		{
			textBox1.ReadOnly = true;
			btnStart.Enabled = false;
			btnCancel.Enabled = true;
			threadEncrypting = new Thread(new ParameterizedThreadStart(Encrypting));
			data.Index = 0;
			threadEncrypting.Start(data);
		}
		
		private byte[] XOR(byte[] buff, string key)
		{
			byte[] result = new byte[buff.Length];
			for (int i = 0; i < buff.Length; i++)
			{
				result[i] = (byte)(buff[i] ^ key[i % key.Length]);
			}			
			return result;
		}

		private void Encrypting(object data)
		{
			Data d = data as Data;
			lock(this){
				try
				{
					fileStream = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
					int fileLength = (int)fileStream.Length;
					if (d.Index != 0) {
						fileLength = d.Index;
					}
					int size = (int)numeric.Value;
					int index = 0;
					byte[] buffer = new byte[size];
					while (index < fileLength)
					{
						fileStream.Read(buffer, 0, size);
						DateTime time = DateTime.Now;						
						buffer = XOR(buffer, textBox1.Text);
						Thread.Sleep(100);
						DateTime time2 = DateTime.Now;
						TimeSpan span = time2 - time;
						d.Speed = span.Milliseconds * (float)numeric.Value / 100f;
						fileStream.Position -= size;
						fileStream.Write(buffer, 0, size);						
						int val = (int)(((float)index / fileLength) * 100);
						progBar.Invoke(new updateProgressBar(ProgressBarUpdate), val);
						
						index += size;
						d.Index = index;
						if (index + size > fileLength)
						{
							size = fileLength - index;
						}
					}					
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					d.Speed = 0;
					btnStart.Invoke(new btnStartEnable(BtnStartEnable), true);
					btnStart.Invoke(new btnCancelEnable(BtnCancelEnable), false);
					progBar.Invoke(new updateProgressBar(ProgressBarUpdate), 0);
					fileStream?.Close();
				}
			}			
		}

		private void BtnOpenFile_Click(object sender, EventArgs e)
		{
			var res = openFileDialog.ShowDialog();
			if(res == DialogResult.OK)
			{
				FileName = openFileDialog.FileName;
				lFileName.Text = FileName;
				textBox1.Enabled = true;
			}
		
		}		
	}
}
