using System;
using UnityEngine;
using XLua;

namespace XLuaTest
{
	public class InvokeLua : MonoBehaviour
	{
		[CSharpCallLua]
		public interface ICalc
		{
			int Mult { get; set; }

			object this[int index] { get; set; }

			event EventHandler<PropertyChangedEventArgs> PropertyChanged;

			int Add(int a, int b);
		}

		[CSharpCallLua]
		public delegate ICalc CalcNew(int mult, params string[] args);

		private string script;

		private void Start()
		{
		}

		private void Test(LuaEnv luaenv)
		{
		}

		private void Notify(object sender, PropertyChangedEventArgs e)
		{
		}

		private void Update()
		{
		}
	}
}
