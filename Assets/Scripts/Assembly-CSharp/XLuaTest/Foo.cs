using System;
using UnityEngine;
using XLua;

namespace XLuaTest
{
	[LuaCallCSharp(GenFlag.No)]
	public class Foo
	{
		public void Test1<T>(T a) where T : Foo1Parent
		{
		}

		public T1 Test2<T1, T2>(T1 a, T2 b, GameObject c) where T1 : Foo1Parent where T2 : Foo2Parent
		{
			return null;
		}

		public void UnsupportedMethod1<T>(T a)
		{
		}

		public void UnsupportedMethod2<T>() where T : Foo1Parent
		{
		}

		public void UnsupportedMethod3<T>(T a) where T : IDisposable
		{
		}
	}
}
