namespace Lab5
{
	partial class Lab5
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.Result = new System.Windows.Forms.ListBox();
			this.VisualSolutionButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NumbersOfTowers = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Source = new System.Windows.Forms.DomainUpDown();
			this.Destination = new System.Windows.Forms.DomainUpDown();
			this.SolveHanoiButton = new System.Windows.Forms.Button();
			this.FiboNumbers = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.Recursively = new System.Windows.Forms.Button();
			this.Iteratively = new System.Windows.Forms.Button();
			this.ColsedFormFormula = new System.Windows.Forms.Button();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.Result);
			this.panel1.Location = new System.Drawing.Point(201, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(833, 605);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Result
			// 
			this.Result.BackColor = System.Drawing.SystemColors.Window;
			this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Result.FormattingEnabled = true;
			this.Result.Location = new System.Drawing.Point(0, 0);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(831, 603);
			this.Result.TabIndex = 0;
			// 
			// VisualSolutionButton
			// 
			this.VisualSolutionButton.Location = new System.Drawing.Point(12, 216);
			this.VisualSolutionButton.Name = "VisualSolutionButton";
			this.VisualSolutionButton.Size = new System.Drawing.Size(172, 35);
			this.VisualSolutionButton.TabIndex = 1;
			this.VisualSolutionButton.Text = "Visual solution";
			this.VisualSolutionButton.UseVisualStyleBackColor = true;
			this.VisualSolutionButton.Click += new System.EventHandler(this.VisualSolutionButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(-14, 320);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "_____________________________";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hanoi towers problem";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(16, 367);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(143, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Fibonacci  numbers";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(16, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "n";
			// 
			// NumbersOfTowers
			// 
			this.NumbersOfTowers.Location = new System.Drawing.Point(125, 71);
			this.NumbersOfTowers.Name = "NumbersOfTowers";
			this.NumbersOfTowers.Size = new System.Drawing.Size(59, 20);
			this.NumbersOfTowers.TabIndex = 6;
			this.NumbersOfTowers.Text = "100";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(16, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "source";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(16, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "destination";
			// 
			// Source
			// 
			this.Source.Items.Add("1");
			this.Source.Items.Add("2");
			this.Source.Items.Add("3");
			this.Source.Location = new System.Drawing.Point(125, 115);
			this.Source.Name = "Source";
			this.Source.Size = new System.Drawing.Size(59, 20);
			this.Source.TabIndex = 9;
			this.Source.Text = "1";
			// 
			// Destination
			// 
			this.Destination.Items.Add("1");
			this.Destination.Items.Add("2");
			this.Destination.Items.Add("3");
			this.Destination.Location = new System.Drawing.Point(125, 149);
			this.Destination.Name = "Destination";
			this.Destination.Size = new System.Drawing.Size(59, 20);
			this.Destination.TabIndex = 10;
			this.Destination.Text = "1";
			// 
			// SolveHanoiButton
			// 
			this.SolveHanoiButton.Location = new System.Drawing.Point(12, 274);
			this.SolveHanoiButton.Name = "SolveHanoiButton";
			this.SolveHanoiButton.Size = new System.Drawing.Size(172, 33);
			this.SolveHanoiButton.TabIndex = 11;
			this.SolveHanoiButton.Text = "Solve";
			this.SolveHanoiButton.UseVisualStyleBackColor = true;
			this.SolveHanoiButton.Click += new System.EventHandler(this.SolveHanoiButton_Click);
			// 
			// FiboNumbers
			// 
			this.FiboNumbers.Location = new System.Drawing.Point(125, 440);
			this.FiboNumbers.Name = "FiboNumbers";
			this.FiboNumbers.Size = new System.Drawing.Size(59, 20);
			this.FiboNumbers.TabIndex = 13;
			this.FiboNumbers.Text = "1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(16, 440);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "n";
			// 
			// Recursively
			// 
			this.Recursively.Location = new System.Drawing.Point(12, 493);
			this.Recursively.Name = "Recursively";
			this.Recursively.Size = new System.Drawing.Size(172, 23);
			this.Recursively.TabIndex = 14;
			this.Recursively.Text = "Solve recursively";
			this.Recursively.UseVisualStyleBackColor = true;
			this.Recursively.Click += new System.EventHandler(this.Recursively_Click);
			// 
			// Iteratively
			// 
			this.Iteratively.Location = new System.Drawing.Point(12, 534);
			this.Iteratively.Name = "Iteratively";
			this.Iteratively.Size = new System.Drawing.Size(172, 23);
			this.Iteratively.TabIndex = 15;
			this.Iteratively.Text = "Solve iteratively";
			this.Iteratively.UseVisualStyleBackColor = true;
			this.Iteratively.Click += new System.EventHandler(this.Iteratively_Click);
			// 
			// ColsedFormFormula
			// 
			this.ColsedFormFormula.Location = new System.Drawing.Point(12, 572);
			this.ColsedFormFormula.Name = "ColsedFormFormula";
			this.ColsedFormFormula.Size = new System.Drawing.Size(172, 23);
			this.ColsedFormFormula.TabIndex = 16;
			this.ColsedFormFormula.Text = "Solve by a closed form formula";
			this.ColsedFormFormula.UseVisualStyleBackColor = true;
			this.ColsedFormFormula.Click += new System.EventHandler(this.ColsedFormFormula_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(1049, 20);
			this.trackBar1.Maximum = 2000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.trackBar1.Size = new System.Drawing.Size(45, 585);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Value = 1000;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(1040, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 16);
			this.label8.TabIndex = 17;
			this.label8.Text = "Speed";
			// 
			// Lab5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 605);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.ColsedFormFormula);
			this.Controls.Add(this.Iteratively);
			this.Controls.Add(this.Recursively);
			this.Controls.Add(this.FiboNumbers);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SolveHanoiButton);
			this.Controls.Add(this.Destination);
			this.Controls.Add(this.Source);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.NumbersOfTowers);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VisualSolutionButton);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1120, 644);
			this.Name = "Lab5";
			this.Text = "Lab5";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button VisualSolutionButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox NumbersOfTowers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DomainUpDown Source;
		private System.Windows.Forms.DomainUpDown Destination;
		private System.Windows.Forms.Button SolveHanoiButton;
		private System.Windows.Forms.TextBox FiboNumbers;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox Result;
		private System.Windows.Forms.Button Recursively;
		private System.Windows.Forms.Button Iteratively;
		private System.Windows.Forms.Button ColsedFormFormula;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label8;
	}
}

