using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThinkingSDK.PC.Constant;
using UnityEngine;

namespace ThinkingSDK.PC.Config
{
	public class ThinkingSDKConfig
	{
		[CompilerGenerated]
		private sealed class _003CGetWithFORM_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ThinkingSDKConfig _003C_003E4__this;

			public Dictionary<string, object> param;

			public ResponseHandle responseHandle;

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
			public _003CGetWithFORM_003Ed__25(int _003C_003E1__state)
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

		private string mToken;

		private string mServerUrl;

		private string mNormalUrl;

		private string mDebugUrl;

		private string mConfigUrl;

		private Mode mMode;

		private TimeZoneInfo mTimeZone;

		public int mUploadInterval;

		public int mUploadSize;

		private List<string> mDisableEvents;

		private static Dictionary<string, ThinkingSDKConfig> sInstances;

		private ThinkingSDKConfig(string token, string serverUrl)
		{
		}

		private string VerifyUrl(string serverUrl)
		{
			return null;
		}

		public void SetMode(Mode mode)
		{
		}

		public Mode GetMode()
		{
			return Mode.NORMAL;
		}

		public string DebugURL()
		{
			return null;
		}

		public string NormalURL()
		{
			return null;
		}

		public string ConfigURL()
		{
			return null;
		}

		public string Server()
		{
			return null;
		}

		public static ThinkingSDKConfig GetInstance(string token, string server)
		{
			return null;
		}

		public void SetTimeZone(TimeZoneInfo timeZoneInfo)
		{
		}

		public TimeZoneInfo TimeZone()
		{
			return null;
		}

		public List<string> DisableEvents()
		{
			return null;
		}

		public bool IsDisabledEvent(string eventName)
		{
			return false;
		}

		public void UpdateConfig(MonoBehaviour mono, ResponseHandle callback = null)
		{
		}

		[IteratorStateMachine(typeof(_003CGetWithFORM_003Ed__25))]
		private IEnumerator GetWithFORM(string url, string appid, Dictionary<string, object> param, ResponseHandle responseHandle)
		{
			return null;
		}
	}
}
