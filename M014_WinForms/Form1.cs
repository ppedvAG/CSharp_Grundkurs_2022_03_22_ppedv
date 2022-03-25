namespace M014_WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DataSource = new List<string>() { "BMW", "Audi", "VW" }; //ComboBox Elemente
			listBox1.DataSource = new List<string>() { "BMW", "Audi", "VW" };
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Test", "Titel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			Form2 f2 = new Form2();
			DialogResult dr = f2.ShowDialog();
			if (dr == DialogResult.OK)
			{
				//...
			}
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Test", "Titel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
			if (dr.HasFlag(DialogResult.OK))
			{
				//...
			}
			if (dr.HasFlag(DialogResult.Cancel))
			{
				//...
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = (CheckBox) sender;
			MessageBox.Show($"CheckBox hat sich geändert {cb.Checked}");
		}
	}
}