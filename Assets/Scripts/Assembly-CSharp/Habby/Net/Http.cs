using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Net.Requests;
using Habby.Net.Responses;
using UnityEngine;
using UnityEngine.Networking;

namespace Habby.Net
{
	public class Http
	{
		[CompilerGenerated]
		private sealed class _003C_Get_003Ed__7<TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public Action<string> onError;

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
			public _003C_Get_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003C_Post_003Ed__9<TResponse> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string path;

			public string requestStr;

			public Action<string> onError;

			public Action<TResponse> callback;

			private int _003Cindex_003E5__2;

			private float _003CmaxDelay_003E5__3;

			private string _003Curl_003E5__4;

			private UnityWebRequest _003CwebRequest_003E5__5;

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
			public _003C_Post_003Ed__9(int _003C_003E1__state)
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

		private const string URL_USER_SERVER = "https://mail-archero.habby.mobi/v1/{0}";

		private const string MESG_HTTP_ERROR = "Invlid response code";

		private static int mPendingMarks;

		private static Dictionary<int, float> mPending;

		public static string URL => null;

		public static void Get<TResponse>(MonoBehaviour coroutineRunner, string url, Action<TResponse> callback, Action<string> onError)
		{
		}

		[IteratorStateMachine(typeof(_003C_Get_003Ed__7<>))]
		private static IEnumerator _Get<TResponse>(string url, Action<TResponse> callback, Action<string> onError)
		{
			return null;
		}

		public static void Post<T, K>(MonoBehaviour coroutineRunner, T requestData, Action<K> callback, Action<string> onError, string url) where T : Request where K : Response
		{
		}

		[IteratorStateMachine(typeof(_003C_Post_003Ed__9<>))]
		private static IEnumerator _Post<TResponse>(string path, string requestStr, Action<TResponse> callback, Action<string> onError)
		{
			return null;
		}

		private static UnityWebRequest createRequest(string url, string requestStr)
		{
			return null;
		}

		private static void onRetrieveData<TResponse>(UnityWebRequest webRequest, Action<TResponse> callback)
		{
		}

		public static void ClearHttpQueue()
		{
		}

		private static int addToPending()
		{
			return 0;
		}

		private static void RemoveLast(int index)
		{
		}
	}
}
