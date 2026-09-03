using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnityPing : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPingConnect_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnityPing _003C_003E4__this;

		private Ping _003Cping_003E5__2;

		private int _003CaddTime_003E5__3;

		private int _003CrequestCount_003E5__4;

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
		public _003CPingConnect_003Ed__10(int _003C_003E1__state)
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

	private static string s_ip;

	private static Action<int> s_callback;

	private static UnityPing s_unityPing;

	private static int s_timeout;

	public static int Timeout
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static void CreatePing(string ip, Action<int> callback)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CPingConnect_003Ed__10))]
	private IEnumerator PingConnect()
	{
		return null;
	}
}
