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
	}
}
