using System;
using UnityEngine;
using XLua;

namespace Tutorial
{
	public class CSCallLua : MonoBehaviour
	{
		public class DClass
		{
			public int f1;

			public int f2;
		}

		[CSharpCallLua]
		public interface ItfD
		{
			int f1 { get; set; }

			int f2 { get; set; }

			int add(int a, int b);
		}

		[CSharpCallLua]
		public delegate int FDelegate(int a, string b, out DClass c);

		[CSharpCallLua]
		public delegate Action GetE();

		private LuaEnv luaenv;

		private string script;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
