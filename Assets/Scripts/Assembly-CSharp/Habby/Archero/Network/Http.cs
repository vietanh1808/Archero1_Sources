using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Net.Requests;
using Habby.Net.Responses;
using UnityEngine;
using UnityEngine.Networking;

namespace Habby.Archero.Network
{
	public class Http
	{
		[CompilerGenerated]
		private sealed class _003C_Get_003Ed__1<TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public Action<string> errCallback;

			public Action<TResponse> callback;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003C_Get_003Ed__1(int _003C_003E1__state)
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
		private sealed class _003C_Post_003Ed__5<TRequest, TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<TResponse> callback;

			public Action<string> onError;

			public string url;

			public TRequest request;

			public int pTimeOut;

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
			public _003C_Post_003Ed__5(int _003C_003E1__state)
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
		private sealed class _003C_Post_003Ed__6<TRequest, TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityWebRequest pWeq;

			public string url;

			public int pTimeOut;

			public TRequest request;

			public Action<string, string> onError;

			public Action<TResponse, string> callback;

			private UnityWebRequest _003CwebRequest_003E5__2;

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
			public _003C_Post_003Ed__6(int _003C_003E1__state)
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

		public static void Get<TResponse>(MonoBehaviour coroutineRunner, string url, Action<TResponse> callback, Action<string> errCallback)
		{
		}

		[IteratorStateMachine(typeof(_003C_Get_003Ed__1<>))]
		private static IEnumerator _Get<TResponse>(string url, Action<TResponse> callback, Action<string> errCallback)
		{
			return null;
		}

		public static void Post<T, K>(MonoBehaviour coroutineRunner, T requestData, Action<K, string> callback, Action<string, string> onError, string url, int pTimeOut = 10) where T : Request where K : Response
		{
		}

		public static UnityWebRequest PostByWerRequest<T, K>(MonoBehaviour coroutineRunner, T requestData, Action<K, string> callback, Action<string, string> onError, string url, int pTimeOut = 10) where T : Request where K : Response
		{
			return null;
		}

		public static void Post<T, K>(MonoBehaviour coroutineRunner, T requestData, Action<K> callback, Action<string> onError, string url, int pTimeOut = 10) where T : Request where K : Response
		{
		}

		[IteratorStateMachine(typeof(_003C_Post_003Ed__5<, >))]
		private static IEnumerator _Post<TRequest, TResponse>(string url, TRequest request, Action<TResponse> callback, Action<string> onError, int pTimeOut = 10)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_Post_003Ed__6<, >))]
		private static IEnumerator _Post<TRequest, TResponse>(string url, TRequest request, Action<TResponse, string> callback, Action<string, string> onError, int pTimeOut = 10, UnityWebRequest pWeq = null)
		{
			return null;
		}
	}
}
