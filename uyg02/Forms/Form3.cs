namespace uyg02.Forms
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void btnCategories_Click(object sender, EventArgs e)
		{
			OpenForm(new Form1());
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			OpenForm(new Form2());
		}

		void OpenForm(Form f)
		{
			panel3.Controls.Clear();
			f.TopLevel = false;
			panel3.Controls.Add(f);
			f.Show();

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}
	}
}
