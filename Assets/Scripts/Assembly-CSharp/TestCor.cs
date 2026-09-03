using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class TestCor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDotest2_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private UnityWebRequest _003Cwww_003E5__2;

		private UnityWebRequestAsyncOperation _003Coperation_003E5__3;

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
		public _003CDotest2_003Ed__4(int _003C_003E1__state)
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

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LoadStreamBundle()
	{
	}

	private void Dotest()
	{
	}

	[IteratorStateMachine(typeof(_003CDotest2_003Ed__4))]
	public IEnumerator Dotest2()
	{
		return null;
	}
}
