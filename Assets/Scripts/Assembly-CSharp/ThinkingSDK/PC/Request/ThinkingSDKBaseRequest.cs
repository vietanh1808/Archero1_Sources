using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ThinkingSDK.PC.Constant;
using UnityEngine.Networking;

namespace ThinkingSDK.PC.Request
{
	public abstract class ThinkingSDKBaseRequest
	{
		[CompilerGenerated]
		private sealed class _003CGetWithFORM_2_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public string appid;

			public Dictionary<string, object> param;

			public ResponseHandle responseHandle;

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
			public _003CGetWithFORM_2_003Ed__12(int _003C_003E1__state)
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

		private string mAppid;

		private string mURL;

		private IList<Dictionary<string, object>> mData;

		public ThinkingSDKBaseRequest(string appid, string url, IList<Dictionary<string, object>> data)
		{
		}

		public ThinkingSDKBaseRequest(string appid, string url)
		{
		}

		public void SetData(IList<Dictionary<string, object>> data)
		{
		}

		public string APPID()
		{
			return null;
		}

		public string URL()
		{
			return null;
		}

		public IList<Dictionary<string, object>> Data()
		{
			return null;
		}

		public static void GetConfig(string url, ResponseHandle responseHandle)
		{
		}

		public bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return false;
		}

		public abstract IEnumerator SendData_2(ResponseHandle responseHandle, IList<Dictionary<string, object>> data);

		[IteratorStateMachine(typeof(_003CGetWithFORM_2_003Ed__12))]
		public static IEnumerator GetWithFORM_2(string url, string appid, Dictionary<string, object> param, ResponseHandle responseHandle)
		{
			return null;
		}
	}
}
