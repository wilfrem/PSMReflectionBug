using System;
using ReflectionTestLib;


namespace ReflectionTest
{
	public class AppMain
	{
		public static void Main (string[] args)
		{
			var type = HelloTypeGetter.Get();
			var obj = Activator.CreateInstance(type);
			Console.WriteLine(obj.ToString());
		}
	}
}
