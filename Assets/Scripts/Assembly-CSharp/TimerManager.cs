using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimerManager
{
	private class TimerBehaviout : MonoBehaviour
	{
		private void OnDestroy()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCoroutine2_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

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
		public _003CCoroutine2_003Ed__17(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoroutine3_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

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
		public _003CCoroutine3_003Ed__19(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoroutine4_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public Action callback;

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
		public _003CCoroutine4_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public Action callback;

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
		public _003CCoroutine_003Ed__13(int _003C_003E1__state)
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

	private static TimerBehaviout m_Timer;

	private static WaitForSeconds _waitOneHour;

	private static WaitForSeconds _waitOneMinute;

	private static WaitForSeconds _waitOneSecond;

	public static WaitForSeconds WaitOneHour => null;

	public static WaitForSeconds WaitOneMinute => null;

	public static WaitForSeconds WaitOneSecond => null;

	public static WaitForSeconds Wait(long cd)
	{
		return null;
	}

	static TimerManager()
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutine_003Ed__13))]
	private static IEnumerator Coroutine(float time, Action callback)
	{
		return null;
	}

	public static Coroutine WaitTime(float time, Action callback)
	{
		return null;
	}

	public static void CancelWait(ref Coroutine coroutine)
	{
	}

	public static void StopCoroutine(Coroutine coroutine)
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutine2_003Ed__17))]
	private static IEnumerator Coroutine2(Action callback)
	{
		return null;
	}

	public static Coroutine WaitFrameEnd(Action callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoroutine3_003Ed__19))]
	private static IEnumerator Coroutine3(Action callback)
	{
		return null;
	}

	public static Coroutine WaitFrameEndForever(Action callback)
	{
		return null;
	}

	public static Coroutine StartCoroutineCustom(IEnumerator enumerator)
	{
		return null;
	}

	public static Coroutine WaitOneFrame(Action callback)
	{
		return null;
	}

	public static Coroutine WaitFrames(int frames, Action callback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoroutine4_003Ed__24))]
	private static IEnumerator Coroutine4(int frames, Action callback)
	{
		return null;
	}
}
