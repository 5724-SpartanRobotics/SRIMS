using System;
using System.Windows.Forms;
using System.IO;

namespace SRIMS
{
	public partial class Settings : Form
	{
		private SRIMSForm parentForm;

		public Settings(SRIMSForm parent)
		{
			InitializeComponent();
			FormClosing += Settings_FormClosing;
			parentForm = parent;
		}

		private void Settings_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
			parentForm.Init();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			dbpath.Text = Properties.Settings.Default.dbloc;
		}

		private void ChangeDatabase_Click(object sender, EventArgs e)
		{
			Stream mystream = null;

			OpenFileDialog op = new OpenFileDialog
			{

				//op.InitialDirectory = "c:\\";
				Filter = "All Files|*.*|CSV Files|*.csv",
				FilterIndex = 3
				//op.RestoreDirectory = true;
			};

			if (op.ShowDialog() == DialogResult.OK)
			{
				if ((mystream = op.OpenFile()) != null)
				{
					mystream.Close();
					// instert code here to change db location on app settings
					dbpath.Text = op.InitialDirectory + op.FileName;
					Properties.Settings.Default.dbloc = op.InitialDirectory + op.FileName;
					parentForm.ClearInventory();
				}

			}
		}

		private void NewDatabase_Click(object sender, EventArgs e)
		{
			Stream mystream = null;

			SaveFileDialog op = new SaveFileDialog
			{

				//op.InitialDirectory = "c:\\";
				Filter = "All Files|*.*|CSV Files|*.csv",
				FilterIndex = 3
				//op.RestoreDirectory = true;
			};

			if (op.ShowDialog() == DialogResult.OK)
			{
				if ((mystream = op.OpenFile()) != null)
				{
					mystream.Close();
					// instert code here to change db location on app settings
					dbpath.Text = op.InitialDirectory + op.FileName;
					Properties.Settings.Default.dbloc = op.InitialDirectory + op.FileName;

					parentForm.ClearInventory();
					parentForm.SaveInventory();
				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.checkout_list = "";
		}
	}
}
