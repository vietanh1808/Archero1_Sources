using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThinkingAnalytics;
using UnityEngine;
using com.adjust.sdk;

namespace Habby
{
	public class TGAnalytics : MonoBehaviour
	{
		[Serializable]
		public struct AbTest
		{
			public string name;

			public int amount;
		}

		[CompilerGenerated]
		private sealed class _003CGetAdid_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TGAnalytics _003C_003E4__this;

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
			public _003CGetAdid_003Ed__28(int _003C_003E1__state)
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

		private string serverUrl;

		public ThinkingAnalyticsAPI.NetworkType networkType;

		public ThinkingAnalyticsAPI.TAMode mode;

		private bool enableLog;

		public AbTest[] abTests;

		private const string TimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

		private static TGAnalytics _instance;

		private static Dictionary<string, int> _abVersions;

		private static DateTime _installTime;

		private static bool _initialized;

		private static bool _running;

		private string _adid;

		private string _networkName;

		private static bool _attributed;

		public static string AppId { get; private set; }

		public static TGAnalytics Instance => null;

		private void Awake()
		{
		}

		public static bool IsInitialized()
		{
			return false;
		}

		[Conditional("EnableTGA")]
		public static void Init(string appId)
		{
		}

		private static void InitAbTests(bool reset = false)
		{
		}

		private static void InitAdjust()
		{
		}

		private void Attribute()
		{
		}

		private void AttributionChangedDelegate(AdjustAttribution attribution)
		{
		}

		[IteratorStateMachine(typeof(_003CGetAdid_003Ed__28))]
		private IEnumerator GetAdid()
		{
			return null;
		}

		private static void Log(string action, string info = "")
		{
		}

		private static void Log(string action, ICollection properties)
		{
		}

		private static void WrapProperties(IDictionary<string, object> properties)
		{
		}

		public static string FormatField(string name)
		{
			return null;
		}

		public static int GetAbVersion(string name)
		{
			return 0;
		}

		public static void ResetAbTests()
		{
		}

		public static void Identify(string uniqueId)
		{
		}

		public static string GetDistinctId()
		{
			return null;
		}

		public static string GetDeviceId()
		{
			return null;
		}

		[Conditional("EnableTGA")]
		public static void Login(string account)
		{
		}

		[Conditional("EnableTGA")]
		public static void Logout()
		{
		}

		[Conditional("EnableTGA")]
		public static void Flush()
		{
		}

		[Conditional("EnableTGA")]
		public static void Track(string eventName, Dictionary<string, object> properties = null)
		{
		}

		[Conditional("EnableTGA")]
		public static void Track(string eventName, Dictionary<string, object> properties, DateTime date)
		{
		}

		[Conditional("EnableTGA")]
		public void Track(ThinkingAnalyticsEvent taEvent)
		{
		}

		[Conditional("EnableTGA")]
		public static void SetSuperProperties(Dictionary<string, object> superProperties)
		{
		}

		[Conditional("EnableTGA")]
		public static void UnsetSuperProperty(string property)
		{
		}

		public static Dictionary<string, object> GetSuperProperties()
		{
			return null;
		}

		[Conditional("EnableTGA")]
		public static void ClearSuperProperties()
		{
		}

		[Conditional("EnableTGA")]
		public static void TimeEvent(string eventName)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserSet(string property, object value)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserSet(Dictionary<string, object> properties)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserSet(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserUnset(string property)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserUnset(List<string> properties)
		{
		}

		[Conditional("EnableTGA")]
		public void UserUnset(List<string> properties, DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserSetOnce(Dictionary<string, object> properties)
		{
		}

		[Conditional("EnableTGA")]
		public void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserAdd(string property, object value)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserAdd(Dictionary<string, object> properties)
		{
		}

		[Conditional("EnableTGA")]
		public void UserAdd(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserAppend(string property, object value)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserAppend(Dictionary<string, object> properties)
		{
		}

		[Conditional("EnableTGA")]
		public void UserAppend(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void UserDelete()
		{
		}

		[Conditional("EnableTGA")]
		public void UserDelete(DateTime dateTime)
		{
		}

		[Conditional("EnableTGA")]
		public static void SetNetworkType(ThinkingAnalyticsAPI.NetworkType networkType)
		{
		}

		[Conditional("EnableTGA")]
		public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties)
		{
		}

		[Conditional("EnableTGA")]
		public static void OptOutTracking()
		{
		}

		[Conditional("EnableTGA")]
		public static void OptOutTrackingAndDeleteUser()
		{
		}

		[Conditional("EnableTGA")]
		public static void OptInTracking()
		{
		}

		[Conditional("EnableTGA")]
		public static void EnableTracking(bool enabled)
		{
		}

		[Conditional("EnableTGA")]
		public static void CalibrateTime(long timestamp)
		{
		}

		[Conditional("EnableTGA")]
		public static void CalibrateTimeWithNtp(string ntpServer)
		{
		}

		private static void CheckInitialization()
		{
		}

		private void OnApplicationFocus(bool focused)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
