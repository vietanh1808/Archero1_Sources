using System;
using UnityEngine;
using XLua;

namespace XLuaTest
{
	[LuaCallCSharp(GenFlag.No)]
	public class LuaBehaviour : MonoBehaviour
	{
		public TextAsset luaScript;

		public Injection[] injections;

		internal static LuaEnv luaEnv;

		internal static float lastGCTime;

		internal const float GCInterval = 1f;

		private Action luaStart;

		private Action luaUpdate;

		private Action luaOnDestroy;

		private LuaTable scriptEnv;

		private void Awake()
		{
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
