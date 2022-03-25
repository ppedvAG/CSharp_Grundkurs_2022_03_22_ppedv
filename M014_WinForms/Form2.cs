namespace M014_WinForms
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void SpeichernClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "Test.txt";
			saveFileDialog.Filter = "Textdokument|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				//saveFileDialog.FileName
			}
		}

		private void OeffnenClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Textdokument|*.txt";
			openFileDialog.FileName = "Test.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				//...
			}
		}
	}
}
