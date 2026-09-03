using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Habby.AssetExpress.Network
{
	public class Http
	{
		[CompilerGenerated]
		private sealed class _003C_Get_003Ed__2<TResponse> : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003C_Get_003Ed__2(int _003C_003E1__state)
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
		private sealed class _003C_Post_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string path;

			public bool encrypt;

			public byte[] requestBody;

			public Action<string> onError;

			public Action<byte[]> callback;

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
			public _003C_Post_003Ed__4(int _003C_003E1__state)
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

		private const string MESG_HTTP_ERROR = "Invlid response code";

		public static void Get<TResponse>(string url, Action<TResponse> callback, Action<string> onError)
		{
		}

		[IteratorStateMachine(typeof(_003C_Get_003Ed__2<>))]
		private static IEnumerator _Get<TResponse>(string url, Action<TResponse> callback, Action<string> onError)
		{
			return null;
		}

		public static void Post(byte[] requestBody, Action<byte[]> callback, Action<string> onError, string url)
		{
		}

		[IteratorStateMachine(typeof(_003C_Post_003Ed__4))]
		private static IEnumerator _Post(string path, byte[] requestBody, Action<byte[]> callback, Action<string> onError, bool encrypt = true)
		{
			return null;
		}

		private static UnityWebRequest createRequest(string url, bool encrypt, byte[] requestBody)
		{
			return null;
		}

		private static void onRetrieveData(UnityWebRequest webRequest, bool encrypt, Action<byte[]> callback)
		{
		}
	}
}
