using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			TestClass obj = new TestClass();
			obj.TestFunction();
		}
	}

	interface TestInterface
	{
		int Prop1 { get; set; }
		string Prop2 { get; }
		bool Prop3 { set; }

		void TestFunction();

		int this[int i] { get; set; }
	}

	class TestClass : TestInterface
	{
		private int prop1 = 100;
		public int Prop1
		{
			get { return prop1; }
			set { prop1 = value; }
		}
		private string prop2 = "apis";
		public string Prop2
		{
			get { return prop2; }
		}
		private bool prop3 = false;
		public bool Prop3
		{
			set { prop3 = value; }
		}

		public void TestFunction()
		{
			Console.WriteLine("Taking api course");
		}

		private int[] arr = new int[100];
		public int this[int i]
		{
			get { return arr[i]; }
			set { arr[i] = value; }
		}

	}
}