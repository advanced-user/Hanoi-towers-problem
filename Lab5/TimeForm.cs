using System.Windows.Forms;

namespace Lab5
{
	public partial class TimeForm : Form
	{
		public TimeForm(string time)
		{
			InitializeComponent();
			label1.Text = "Milliseconds: " + time;
		}
	}
}
