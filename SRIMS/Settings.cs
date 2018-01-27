using SRIMS.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace SRIMS
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			FormClosed += Settings_FormClosed;
		}

		private void Settings_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Save();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			dbpath.Text = Settings.Default.dbloc;
		}

		private void ChangeDatabase_Click(object sender, EventArgs e)
		{
			Stream mystream = null;

			OpenFileDialog op = new OpenFileDialog
			{

				//op.InitialDirectory = "c:\\";
				Filter = "All Files|*.*|JSON Files|*.json",
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
					Settings.Default.dbloc = op.InitialDirectory + op.FileName;
					SRIMSForm.Instance.ClearInventory();
					Close();
				}

			}
		}

		private void NewDatabase_Click(object sender, EventArgs e)
		{
			Stream mystream = null;

			SaveFileDialog op = new SaveFileDialog
			{

				//op.InitialDirectory = "c:\\";
				Filter = "All Files|*.*|JSON Files|*.json",
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

					SRIMSForm.Instance.ClearInventory();
					SRIMSForm.Instance.SaveInventory();
				}

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.CheckoutList = "";
		}
	}
}
