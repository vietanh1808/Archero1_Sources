using UnityEngine;
using XLua;

namespace XLuaTest
{
	[LuaCallCSharp(GenFlag.No)]
	public static class FooExtension
	{
		public static void PlainExtension(this Foo1Parent a)
		{
		}

		public static T Extension1<T>(this T a) where T : Foo1Parent
		{
			return null;
		}

		public static T Extension2<T>(this T a, GameObject b) where T : Foo1Parent
		{
			return null;
		}

		public static void Extension2<T1, T2>(this T1 a, T2 b) where T1 : Foo1Parent where T2 : Foo2Parent
		{
		}

		public static T UnsupportedExtension<T>(this GameObject obj) where T : Component
		{
			return null;
		}
	}
}
