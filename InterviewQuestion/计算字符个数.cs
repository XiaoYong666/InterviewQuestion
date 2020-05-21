using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestion
{
	public class 计算字符个数
	{
		static void Main(string[] args)
		{
			string inputStr = Console.ReadLine()?.ToLower().ToString(); ;
			var res = GetCharInStringCount(((char)Console.Read()).ToString(), inputStr);
			Console.WriteLine(res);
			Console.ReadKey();
		}

		public static int GetCharInStringCount(string charStr, string str)
		{
			string res = str.Replace(charStr, "");
			return str.Length - res.Length;
		}
	}
}
