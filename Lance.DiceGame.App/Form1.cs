namespace Lance.DiceGame.App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IDiceGame game = new SimpleDiceGame();
			game.Play();

			string row = game.Tital + " " + game.GetInformation() + "\r\n";
			textBox1.Text += row;
		}

	}
}