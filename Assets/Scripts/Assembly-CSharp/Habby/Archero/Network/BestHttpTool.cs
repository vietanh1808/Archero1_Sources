using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BestHTTP;
using Habby.Net.Requests;
using Habby.Net.Responses;
using UnityEngine;

namespace Habby.Archero.Network
{
	public class BestHttpTool : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoPost_003Ed__5<TRequest, TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HTTPRequest pWeq;

			public string url;

			public int pTimeOut;

			public TRequest request;

			public Action<TResponse, string> callback;

			public Action<string, string> onError;

			private HTTPRequest _003Ctreq_003E5__2;

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
			public _003CDoPost_003Ed__5(int _003C_003E1__state)
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

		private static BestHttpTool sInstance;

		private static BestHttpTool Ins => null;

		public static HTTPRequest PostByHttpRequest<T, K>(T requestData, Action<K, string> callback, Action<string, string> onError, string url, int pTimeOut = 60) where T : Request where K : Response
		{
			return null;
		}

		public static void SendPost<T, K>(T requestData, Action<K, string> callback, Action<string, string> onError, string url, int pTimeOut = 60, HTTPRequest pWeq = null) where T : Request where K : Response
		{
		}

		[IteratorStateMachine(typeof(_003CDoPost_003Ed__5<, >))]
		private static IEnumerator DoPost<TRequest, TResponse>(string url, TRequest request, Action<TResponse, string> callback, Action<string, string> onError, int pTimeOut = 60, HTTPRequest pWeq = null)
		{
			return null;
		}
	}
}
