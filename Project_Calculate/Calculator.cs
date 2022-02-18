using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Calculate
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
			test_Addition();
			test_Substruct();
			test_Division();
			test_Multiply();
			test_findRoots();
		}

		private void button_Plus_Click(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(textBox_num1.Text);
				double num2 = Convert.ToDouble(textBox_num2.Text);
				double res = addition(num1, num2);
				textBox_res.Text = Convert.ToString(res);
			}
			catch (FormatException)
			{
				MessageBox.Show("Некорректные числа");
				textBox_res.Text = "Error";
			}
		}

		private void button_Minus_Click(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(textBox_num1.Text);
				double num2 = Convert.ToDouble(textBox_num2.Text);
				double res = substruct(num1, num2);
				textBox_res.Text = Convert.ToString(res);
			}
			catch (FormatException)
			{
				MessageBox.Show("Некорректные числа");
				textBox_res.Text = "Error";
			}
		}

		private void button_Mult_Click(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(textBox_num1.Text);
				double num2 = Convert.ToDouble(textBox_num2.Text);
				double res = multiply(num1, num2);
				textBox_res.Text = Convert.ToString(res);
			}
			catch (FormatException)
			{
				MessageBox.Show("Некорректные числа");
				textBox_res.Text = "Error";
			}
		}

		private void button_Division_Click(object sender, EventArgs e)
		{
			try
			{
				double num1 = Convert.ToDouble(textBox_num1.Text);
				double num2 = Convert.ToDouble(textBox_num2.Text);
				double res = division(num1, num2);
				textBox_res.Text = Convert.ToString(res);
			}
			catch (FormatException)
			{
				MessageBox.Show("Некорректные числа");
				textBox_res.Text = "Error";
			}
		}

		private void button_FindRoots_Click(object sender, EventArgs e)
		{
			try
			{
				double A = Convert.ToDouble(textBox_valA.Text);
				double B = Convert.ToDouble(textBox_valB.Text);
				double C = Convert.ToDouble(textBox_valC.Text);
				List<double> roots = findRoots(A, B, C);
				if (roots.Count == 1){
					textBox_Roots.Text = string.Format("x1 = {0:F2}", roots[0]);
				}
				else if (roots.Count == 2){
					textBox_Roots.Text = string.Format("x1 = {0:F2}; x2 = {1:F2}", roots[0], roots[1]);
				}
				else
				{
					textBox_Roots.Text = "Дискриминант меньше 0";
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Некорректные числа");
				textBox_res.Text = "Error";
			}
		}

		public static double addition(double first, double second)
		{
			return first + second;
		}

		public void test_Addition()
		{
			double num1 = 100;
			double num2 = 101;
			double res = 201;
			Console.Write("ТЕСТ ФУНКЦИИ addition():");
			if (addition(num1, num2) == res)
			{
				Console.WriteLine("Успешно");
			}
			else
			{
				Console.WriteLine("Грустно");
			}
		}


		public static double substruct(double first, double second)
		{
			return first - second;
		}

		public void test_Substruct()
		{
			double num1 = 100;
			double num2 = 101;
			double res = -1;
			Console.Write("ТЕСТ ФУНКЦИИ substruct():");
			if (substruct(num1, num2) == res)
			{
				Console.WriteLine("Успешно");
			}
			else
			{
				Console.WriteLine("Грустно");
			}
		}

		public static double multiply(double first, double second)
		{
			return first * second;
		}

		public void test_Multiply()
		{
			double num1 = 100;
			double num2 = 101;
			double res = 10100;
			Console.Write("ТЕСТ ФУНКЦИИ multiply():");
			if (multiply(num1, num2) == res)
			{
				Console.WriteLine("Успешно");
			}
			else
			{
				Console.WriteLine("Грустно");
			}
		}

		public static double division(double first, double second)
		{
			return first / second;
		}

		public void test_Division()
		{
			double num1 = 101;
			double num2 = 100;
			double res = 1.01;
			Console.Write("ТЕСТ ФУНКЦИИ division():");
			if (division(num1, num2) == res)
			{
				Console.WriteLine("Успешно");
			}
			else
			{
				Console.WriteLine("Грустно");
			}
		}

		public static List<double> findRoots(double A, double B, double C)
		{
			List<double> roots = new List<double>();
			double D = B * B - 4 * A * C;
			if (D == 0)
			{
				roots.Add(-B / (2 * A));
			}
			else if (D > 0)
			{
				roots.Add((-B + Math.Sqrt(D)) / (2 * A));
				roots.Add((-B - Math.Sqrt(D)) / (2 * A));
			}
			return roots;
		}
	}
}
