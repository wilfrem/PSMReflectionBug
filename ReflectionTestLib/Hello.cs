using System;

namespace ReflectionTestLib
{
	class Hello
	{
		public Hello ()
		{
		}
		public override string ToString ()
		{
			return "Hello, ";
		}
	}
	public static class HelloTypeGetter
	{
		public static Type Get(){return typeof(Hello);}
	}
}

