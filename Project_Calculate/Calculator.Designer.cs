
namespace Project_Calculate
{
	partial class Calculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_num2 = new System.Windows.Forms.TextBox();
			this.textBox_num1 = new System.Windows.Forms.TextBox();
			this.textBox_res = new System.Windows.Forms.TextBox();
			this.button_Plus = new System.Windows.Forms.Button();
			this.button_Minus = new System.Windows.Forms.Button();
			this.button_Mult = new System.Windows.Forms.Button();
			this.button_Division = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_valA = new System.Windows.Forms.TextBox();
			this.textBox_valB = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_valC = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox_Roots = new System.Windows.Forms.TextBox();
			this.button_FindRoots = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(93, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Первое число";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(93, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Второе число";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(93, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Результат";
			// 
			// textBox_num2
			// 
			this.textBox_num2.Location = new System.Drawing.Point(96, 159);
			this.textBox_num2.Name = "textBox_num2";
			this.textBox_num2.Size = new System.Drawing.Size(100, 22);
			this.textBox_num2.TabIndex = 3;
			// 
			// textBox_num1
			// 
			this.textBox_num1.Location = new System.Drawing.Point(96, 81);
			this.textBox_num1.Name = "textBox_num1";
			this.textBox_num1.Size = new System.Drawing.Size(100, 22);
			this.textBox_num1.TabIndex = 4;
			// 
			// textBox_res
			// 
			this.textBox_res.Location = new System.Drawing.Point(96, 247);
			this.textBox_res.Name = "textBox_res";
			this.textBox_res.Size = new System.Drawing.Size(100, 22);
			this.textBox_res.TabIndex = 5;
			// 
			// button_Plus
			// 
			this.button_Plus.BackColor = System.Drawing.SystemColors.Desktop;
			this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Plus.ForeColor = System.Drawing.SystemColors.Control;
			this.button_Plus.Location = new System.Drawing.Point(329, 82);
			this.button_Plus.Name = "button_Plus";
			this.button_Plus.Size = new System.Drawing.Size(60, 60);
			this.button_Plus.TabIndex = 6;
			this.button_Plus.Text = "+";
			this.button_Plus.UseVisualStyleBackColor = false;
			this.button_Plus.Click += new System.EventHandler(this.button_Plus_Click);
			// 
			// button_Minus
			// 
			this.button_Minus.BackColor = System.Drawing.SystemColors.Desktop;
			this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Minus.Location = new System.Drawing.Point(415, 82);
			this.button_Minus.Name = "button_Minus";
			this.button_Minus.Size = new System.Drawing.Size(60, 60);
			this.button_Minus.TabIndex = 7;
			this.button_Minus.Text = "-";
			this.button_Minus.UseVisualStyleBackColor = false;
			this.button_Minus.Click += new System.EventHandler(this.button_Minus_Click);
			// 
			// button_Mult
			// 
			this.button_Mult.BackColor = System.Drawing.SystemColors.Desktop;
			this.button_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Mult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Mult.Location = new System.Drawing.Point(329, 170);
			this.button_Mult.Name = "button_Mult";
			this.button_Mult.Size = new System.Drawing.Size(60, 60);
			this.button_Mult.TabIndex = 8;
			this.button_Mult.Text = "*";
			this.button_Mult.UseVisualStyleBackColor = false;
			this.button_Mult.Click += new System.EventHandler(this.button_Mult_Click);
			// 
			// button_Division
			// 
			this.button_Division.BackColor = System.Drawing.SystemColors.Desktop;
			this.button_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Division.Location = new System.Drawing.Point(415, 170);
			this.button_Division.Name = "button_Division";
			this.button_Division.Size = new System.Drawing.Size(60, 60);
			this.button_Division.TabIndex = 9;
			this.button_Division.Text = "/";
			this.button_Division.UseVisualStyleBackColor = false;
			this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.panel1.Location = new System.Drawing.Point(301, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 190);
			this.panel1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 321);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "a";
			// 
			// textBox_valA
			// 
			this.textBox_valA.Location = new System.Drawing.Point(96, 321);
			this.textBox_valA.Name = "textBox_valA";
			this.textBox_valA.Size = new System.Drawing.Size(100, 22);
			this.textBox_valA.TabIndex = 12;
			// 
			// textBox_valB
			// 
			this.textBox_valB.Location = new System.Drawing.Point(251, 321);
			this.textBox_valB.Name = "textBox_valB";
			this.textBox_valB.Size = new System.Drawing.Size(100, 22);
			this.textBox_valB.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(229, 321);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "b";
			// 
			// textBox_valC
			// 
			this.textBox_valC.Location = new System.Drawing.Point(405, 321);
			this.textBox_valC.Name = "textBox_valC";
			this.textBox_valC.Size = new System.Drawing.Size(100, 22);
			this.textBox_valC.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(383, 321);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "c";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(71, 385);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Корни";
			// 
			// textBox_Roots
			// 
			this.textBox_Roots.Location = new System.Drawing.Point(126, 385);
			this.textBox_Roots.Name = "textBox_Roots";
			this.textBox_Roots.Size = new System.Drawing.Size(242, 22);
			this.textBox_Roots.TabIndex = 18;
			// 
			// button_FindRoots
			// 
			this.button_FindRoots.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.button_FindRoots.Location = new System.Drawing.Point(405, 380);
			this.button_FindRoots.Name = "button_FindRoots";
			this.button_FindRoots.Size = new System.Drawing.Size(100, 33);
			this.button_FindRoots.TabIndex = 19;
			this.button_FindRoots.Text = "Вычислить";
			this.button_FindRoots.UseVisualStyleBackColor = false;
			this.button_FindRoots.Click += new System.EventHandler(this.button_FindRoots_Click);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 457);
			this.Controls.Add(this.button_FindRoots);
			this.Controls.Add(this.textBox_Roots);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_valC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox_valB);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_valA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_Division);
			this.Controls.Add(this.button_Mult);
			this.Controls.Add(this.button_Minus);
			this.Controls.Add(this.button_Plus);
			this.Controls.Add(this.textBox_res);
			this.Controls.Add(this.textBox_num1);
			this.Controls.Add(this.textBox_num2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "Calculator";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox_num2;
		private System.Windows.Forms.TextBox textBox_num1;
		private System.Windows.Forms.TextBox textBox_res;
		private System.Windows.Forms.Button button_Plus;
		private System.Windows.Forms.Button button_Minus;
		private System.Windows.Forms.Button button_Mult;
		private System.Windows.Forms.Button button_Division;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_valA;
		private System.Windows.Forms.TextBox textBox_valB;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_valC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox_Roots;
		private System.Windows.Forms.Button button_FindRoots;
	}
}

