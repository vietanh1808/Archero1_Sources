using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThinkingSDK.PC.Constant;
using UnityEngine.Networking;

namespace ThinkingSDK.PC.Request
{
	public class ThinkingSDKDebugRequest : ThinkingSDKBaseRequest
	{
		[CompilerGenerated]
		private sealed class _003CSendData_2_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ThinkingSDKDebugRequest _003C_003E4__this;

			public IList<Dictionary<string, object>> data;

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
			public _003CSendData_2_003Ed__5(int _003C_003E1__state)
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

		private int mDryRun;

		private string mDeviceID;

		public void SetDryRun(int dryRun)
		{
		}

		public ThinkingSDKDebugRequest(string appid, string url, IList<Dictionary<string, object>> data)
			: base(null, null, null)
		{
		}

		public ThinkingSDKDebugRequest(string appid, string url)
			: base(null, null, null)
		{
		}

		[IteratorStateMachine(typeof(_003CSendData_2_003Ed__5))]
		public override IEnumerator SendData_2(ResponseHandle responseHandle, IList<Dictionary<string, object>> data)
		{
			return null;
		}
	}
}
