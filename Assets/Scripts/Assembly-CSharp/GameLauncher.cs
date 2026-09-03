using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLauncher _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int ImprintId;

	public int ImprintLevel;

	private static GameLauncher _Instance;

	private bool bInit;

	private byte[] offsetMemery;

	public LuaAppFacade luaFacade;

	private int testFps;

	private static float avgDuration;

	private static float alpha;

	private static int frameCount;

	private float touchtime;

	private Vector4 shaderUnscaledTime;

	private bool bPause;

	public static GameLauncher Instance => null;

	public static int MaxPoolObjCount => 0;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__8))]
	private IEnumerator Start()
	{
		return null;
	}

	private void initGlobalCommands()
	{
	}

	public void init()
	{
	}

	public bool init1()
	{
		return false;
	}

	private void Init1Implent(Action action, string name)
	{
	}

	public bool init2()
	{
		return false;
	}

	public bool init3()
	{
		return false;
	}

	public bool init4()
	{
		return false;
	}

	protected void _InitNameGenerator()
	{
	}

	protected void _InitPureMVC()
	{
	}

	private void OnApplicationFocus(bool focusStatus)
	{
	}

	private int fps(float deltaTime)
	{
		return 0;
	}

	private void Update()
	{
	}

	private void TestKeyInput()
	{
	}

	private void UpdateShaderTime()
	{
	}

	private void update_touch()
	{
	}

	public void on_gamecenter_change(string json)
	{
	}

	public void on_login_callback(string json)
	{
	}

	private void OnApplicationQuit()
	{
	}
}
