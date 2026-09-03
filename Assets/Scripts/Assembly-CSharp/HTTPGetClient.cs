using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class HTTPGetClient : MonoBehaviour
{
	public class HTTPGetData
	{
		public string header;

		public string body;
	}

	[CompilerGenerated]
	private sealed class _003CSendGetInternal_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HTTPGetClient _003C_003E4__this;

		public string uri;

		public Action<string> callback;

		private UnityWebRequest _003C_003E7__wrap1;

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
		public _003CSendGetInternal_003Ed__11(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendPostInternal_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HTTPGetClient _003C_003E4__this;

		public string uri;

		public WWWForm form;

		public Action<string> callback;

		private UnityWebRequest _003C_003E7__wrap1;

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
		public _003CSendPostInternal_003Ed__13(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static GameObject _HTTPGetObject;

	private UnityWebRequest _uwr;

	private float starttime;

	private static GameObject HTTPGetObject => null;

	private bool isTimeOut => false;

	public static void SendGet(string uri, Action<string> callback)
	{
	}

	public static void SendPost(string uri, WWWForm form, Action<string> callback)
	{
	}

	public void StartSendGet(string uri, Action<string> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CSendGetInternal_003Ed__11))]
	public IEnumerator SendGetInternal(string uri, Action<string> callback)
	{
		return null;
	}

	public void StartSendPost(string uri, WWWForm form, Action<string> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CSendPostInternal_003Ed__13))]
	public IEnumerator SendPostInternal(string uri, WWWForm form, Action<string> callback)
	{
		return null;
	}
}
