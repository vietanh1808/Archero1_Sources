using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThinkingSDK.PC.Constant;
using ThinkingSDK.PC.Request;
using UnityEngine;

namespace ThinkingSDK.PC.TaskManager
{
	[DisallowMultipleComponent]
	public class ThinkingSDKTask : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSendData_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ThinkingSDKBaseRequest mRequest;

			public ResponseHandle responseHandle;

			public IList<Dictionary<string, object>> list;

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
			public _003CSendData_003Ed__15(int _003C_003E1__state)
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

		private static readonly object _locker;

		private List<ThinkingSDKBaseRequest> requestList;

		private List<ResponseHandle> responseHandleList;

		private List<IList<Dictionary<string, object>>> dataList;

		private static ThinkingSDKTask mSingleTask;

		private bool isWaiting;

		public static ThinkingSDKTask SingleTask()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void WaitOne()
		{
		}

		public void Release()
		{
		}

		public void SyncInvokeAllTask()
		{
		}

		public void StartRequest(ThinkingSDKBaseRequest mRequest, ResponseHandle responseHandle, IList<Dictionary<string, object>> list)
		{
		}

		private void StartRequestSendData()
		{
		}

		[IteratorStateMachine(typeof(_003CSendData_003Ed__15))]
		private IEnumerator SendData(ThinkingSDKBaseRequest mRequest, ResponseHandle responseHandle, IList<Dictionary<string, object>> list)
		{
			return null;
		}
	}
}
