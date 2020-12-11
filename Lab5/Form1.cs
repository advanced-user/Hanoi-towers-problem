using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab5
{
	public partial class Lab5 : Form
	{
		readonly MyColor[] colors;
		CancellationTokenSource cts;
		Stopwatch stopWatch;

		int[] a;
		int[] b;
		int[] c;
		int len = 100;
		int speed = 1000;

		public Lab5()
		{
			a = new int[100];
			b = new int[100];
			c = new int[100];

			for(int i = 0; i < len; i++)
			{
				a[i] = len - i;
				b[i] = c[i] = 0;
			}

			colors = new MyColor[7];
			colors[0] = new MyColor(255, 0, 0);
			colors[1] = new MyColor(255, 128, 0);
			colors[2] = new MyColor(255, 255, 0);
			colors[3] = new MyColor(0, 255, 0);
			colors[4] = new MyColor(0, 255, 255);
			colors[5] = new MyColor(0, 0, 255);
			colors[6] = new MyColor(128, 0, 255);

			cts = new CancellationTokenSource();
			stopWatch = new Stopwatch();

			InitializeComponent();

			Result.Visible = false;
			MyColor.Max = panel1.Height;
		}

		Color GetColor(int i)
		{
			double len = (int)(panel1.Height / 6);
			int n = (int)(i / len);
			double k = (i - len * n) / len;
			int r, g, b;
			if (n > 5)
				n = 0;
			r = (int)(colors[n].R + (colors[n+1].R - colors[n].R)*k);
			g = (int)(colors[n].G + (colors[n + 1].G - colors[n].G) * k);
			b = (int)(colors[n].B + (colors[n + 1].B - colors[n].B) * k);

			return Color.FromArgb(255, r, g, b); 
		}

		public void Draw(int[] a, int n, PaintEventArgs e)
		{
			int pos = panel1.Width / 4;

			e.Graphics.FillRectangle(new SolidBrush(Color.Gray), n * pos - 5, 0, 5, panel1.Height);
			e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 0, panel1.Height - 20, panel1.Width, 20);
			
			for(int i = 0; i < len; i++)
			{
				if(a[i] > 0)
					e.Graphics.FillRectangle(new SolidBrush(GetColor(panel1.Height * a[i] / len * 4 / 5)), n * pos - 100*a[i]/len, panel1.Height - 20 - panel1.Height / len * 4 / 5 * (i + 1), 200 * a[i] / len, panel1.Height / len * 4 / 5);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Draw(a, 1, e);
			Draw(b, 2, e);
			Draw(c, 3, e);
		}

		private async void VisualSolutionButton_Click(object sender, EventArgs e)
		{
			Result.Visible = false;
			cts.Cancel();

			try
			{
				len = Convert.ToInt32(NumbersOfTowers.Text);
				if(len < 0)
				{
					TimeForm form = new TimeForm("Введите корректное количество башен");
					form.ShowDialog();
					return;
				}
				int source = Convert.ToInt32(Source.Text);
				int destination = Convert.ToInt32(Destination.Text);

				Remove();
				panel1.Invalidate();

				cts = new CancellationTokenSource();
				Result.Items.Clear();
				Thread.Sleep(500);

				Build(source, len);

				panel1.Invalidate();

				CancellationToken token = cts.Token;

				if (source == destination)
					return;

				await Task.Run(() => VisualHanoy(len, source, destination, token));
			}
			catch
			{
				TimeForm form = new TimeForm("Введите корректное количество башен");
				form.ShowDialog();
			}

		}

		private void Remove()
		{
			for (int i = 0; i < len; i++)
			{
				a[i] = b[i] = c[i] = 0;
			}
		}

		private void Build(int source, int len)
		{
			switch (source)
			{
				case 1:
					for (int i = 0; i < len; i++)
					{
						a[i] = len - i;
						b[i] = c[i] = 0;
					}
					break;
				case 2:
					for (int i = 0; i < len; i++)
					{
						b[i] = len - i;
						a[i] = c[i] = 0;
					}
					break;
				case 3:
					for (int i = 0; i < len; i++)
					{
						c[i] = len - i;
						b[i] = a[i] = 0;
					}
					break;
			}
		}

		private int Index(int[] mass)
		{
			for(int i = len - 1; i >= 0; i--)
			{
				if (mass[i] != 0)
				{
					return i;
				}
			}
			return 0;
		}

		private void VisualHanoy(int n, int s, int d, CancellationToken token)
		{
			if (token.IsCancellationRequested)
				return;
			if (n != 0)
			{
				int m = 6 - s - d;
				VisualHanoy(n - 1, s, m, token);
				int length = 0;
				if (token.IsCancellationRequested)
					return;
				switch (s)
				{
					case 1:
						int index = Index(a);
						length = a[index];
						a[index] = 0;
						break;
					case 2:
						index = Index(b);
						length = b[index];
						b[index] = 0;
						break;
					case 3:
						index = Index(c);
						length = c[index];
						c[index] = 0;
						break;
				}
				switch (d)
				{
					case 1:
						int index = Index(a);
						if (index == 0 && a[0] != 0)
							a[index + 1] = length;
						else if(index == 0 || index == len-1)
							a[index] = length;
						else
						{
							a[index + 1] = length;
						}
						break;
					case 2:
						index = Index(b);
						if (index == 0 && b[0] != 0)
							b[index + 1] = length;
						else if (index == 0 || index == len - 1)
							b[index] = length;
						else
						{
							b[index + 1] = length;
						}
						break;
					case 3:
						index = Index(c);
						if (index == 0 && c[0] != 0)
							c[index + 1] = length;
						else if (index == 0 || index == len - 1)
							c[index] = length;
						else
						{
							c[index + 1] = length;
						}
						break;
				}
				panel1.Invalidate();
				Thread.Sleep(speed);

				VisualHanoy(n - 1, m, d, token);
			}
		}

		private async void SolveHanoiButton_Click(object sender, EventArgs e)
		{
			Result.Visible = true;
			await Task.Run(()=> HanoyAsync());
		}

		private void HanoyAsync()
		{
			cts.Cancel();
			cts = new CancellationTokenSource();
			Result.Items.Clear();

			int n;
			try
			{
				n = Convert.ToInt32(NumbersOfTowers.Text);
				if (n < 0)
				{
					Result.Items.Add("Введите корректное число");
					return;
				}
				int source = Convert.ToInt32(Source.Text);
				int destination = Convert.ToInt32(Destination.Text);

				if(source == destination)
				{
					Result.Items.Add("Башня уже на месте");
					return;
				}

				CancellationToken token = cts.Token;

				stopWatch.Start();
				Hanoy(n, source, destination, token);
				stopWatch.Stop();

				TimeForm form = new TimeForm(stopWatch.ElapsedMilliseconds.ToString());
				form.ShowDialog();
			}
			catch
			{
				Result.Items.Add("Введите корректное число");
			}
		}

		private void Hanoy(int n, int s, int d, CancellationToken token)
		{
			if (token.IsCancellationRequested)
				return;
			if(n != 0)
			{
				int m = 6 - s - d;
				Hanoy(n - 1, s, m, token);
				if (token.IsCancellationRequested)
				{
					stopWatch.Stop();
					return;
				}
				Result.Items.Add(s + "->" + d);
				Hanoy(n - 1, m, d, token);
			}
		}

		private async void Recursively_Click(object sender, EventArgs e)
		{
			Result.Visible = true;
			cts.Cancel();
			cts = new CancellationTokenSource();
			Result.Items.Clear();

			int n;
			try
			{
				n = Convert.ToInt32(FiboNumbers.Text);
				if (n > 0)
					await Task.Run(() => RecursivelyFiboAsync(n));
				else if (n == 0)
					Result.Items.Add("0");
			}
			catch
			{
				Result.Items.Add("Введите корректное число");
			}

		}

		private void RecursivelyFiboAsync(int n)
		{
			cts.Cancel();
			cts = new CancellationTokenSource();
			CancellationToken token = cts.Token;
			stopWatch.Start();
			decimal result = RecursivelyFibo(n, token);
			Result.Items.Add(result);
			stopWatch.Stop();

			TimeForm form = new TimeForm(stopWatch.ElapsedMilliseconds.ToString());
			form.ShowDialog();
		}

		private decimal RecursivelyFibo(decimal n, CancellationToken token)
		{
			if (token.IsCancellationRequested)
			{
				stopWatch.Stop();
				return 0;
			}
			if (n < 3)
				return 1;
			return RecursivelyFibo(n - 1, token) + RecursivelyFibo(n - 2, token);
		}

		private async void Iteratively_Click(object sender, EventArgs e)
		{
			Result.Visible = true;
			cts.Cancel();
			cts = new CancellationTokenSource();
			Result.Items.Clear();

			int n;
			try
			{
				n = Convert.ToInt32(FiboNumbers.Text);
				if (n > 2)
					await Task.Run(() => SolveIteratively(n));
				else if (n == 1 || n == 2)
					Result.Items.Add("1");
				else if (n == 0)
					Result.Items.Add("0");
			}
			catch
			{
				Result.Items.Add("Введите корректное число");
			}

		}

		private void SolveIteratively(int n)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			decimal[] fib = new decimal[n];
			fib[0] = 1;
			fib[1] = 1;
			for(int i = 2; i < n; i++)
			{
				fib[i] = fib[i - 1] + fib[i - 2];
			}
			Result.Items.Add(fib[n-1]);
			stopwatch.Stop();

			TimeForm form = new TimeForm(stopwatch.ElapsedMilliseconds.ToString());
			form.ShowDialog();
		}

		private async void ColsedFormFormula_Click(object sender, EventArgs e)
		{
			Result.Visible = true;
			cts.Cancel();
			cts = new CancellationTokenSource();
			Result.Items.Clear();

			int n;
			try
			{
				n = Convert.ToInt32(FiboNumbers.Text);
				if (n >= 0)
					await Task.Run(() => SolveByFormula(n));
			}
			catch
			{
				Result.Items.Add("Введите корректное число");
			}
		}

		private void SolveByFormula(int n)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			double sqrt5 = Math.Sqrt(5);
			double phi = (sqrt5 + 1) / 2;

			Result.Items.Add((long)(Math.Pow(phi, n) / sqrt5 + 0.5));

			stopwatch.Stop();
			TimeForm form = new TimeForm(stopwatch.ElapsedMilliseconds.ToString());
			form.ShowDialog();
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			speed = trackBar1.Value;
		}
	}
}
