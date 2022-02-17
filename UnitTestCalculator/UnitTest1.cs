using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Calculate
{
	[TestClass]
	public class UnitTest1
	{


		[TestMethod]
		public void test_Addition()
		{
			double num1 = 10;
			double num2 = -20;
			double result = -10;
			Assert.AreEqual(result, Project_Calculate.Calculator.addition(num1, num2));
		}

		[TestMethod]
		public void test_Substruct()
		{
			double num1 = 10;
			double num2 = -20;
			double result = 30;
			Assert.AreEqual(result, Project_Calculate.Calculator.substruct(num1, num2));
		}

		[TestMethod]
		public void test_Multiplication()
		{
			double num1 = 10;
			double num2 = -20;
			double result = -200;
			Assert.AreEqual(result, Project_Calculate.Calculator.multiply(num1, num2));
		}

		[TestMethod]
		public void test_Division()
		{
			double num1 = 10;
			double num2 = -20;
			double result = -0.5;
			Assert.AreEqual(result, Project_Calculate.Calculator.division(num1, num2));
		}

		[TestMethod]
		public void test_findRoots()
		{
			double A = 1;
			double B = 3;
			double C = -4;
			List<double> result = new List<double>() {1, -4};
			Assert.AreEqual(true, result.SequenceEqual(Project_Calculate.Calculator.findRoots(A, B, C)));
		}
	}
}
