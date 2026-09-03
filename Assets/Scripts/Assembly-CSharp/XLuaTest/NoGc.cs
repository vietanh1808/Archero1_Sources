using System;
using UnityEngine;
using XLua;

namespace XLuaTest
{
	[LuaCallCSharp(GenFlag.No)]
	public class NoGc : MonoBehaviour
	{
		private LuaEnv luaenv;

		private IntParam f1;

		private Vector3Param f2;

		private CustomValueTypeParam f3;

		private EnumParam f4;

		private DecimalParam f5;

		private ArrayAccess farr;

		private Action flua;

		private IExchanger ie;

		private LuaFunction add;

		[NonSerialized]
		public double[] a1;

		[NonSerialized]
		public Vector3[] a2;

		[NonSerialized]
		public MyStruct[] a3;

		[NonSerialized]
		public MyEnum[] a4;

		[NonSerialized]
		public decimal[] a5;

		public float FloatParamMethod(float p)
		{
			return 0f;
		}

		public Vector3 Vector3ParamMethod(Vector3 p)
		{
			return default;
		}

		public MyStruct StructParamMethod(MyStruct p)
		{
			return default;
		}

		public MyEnum EnumParamMethod(MyEnum p)
		{
			return MyEnum.E1;
		}

		public decimal DecimalParamMethod(decimal p)
		{
			return 0m;
		}

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
