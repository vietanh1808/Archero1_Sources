using System;
using System.Collections.Generic;
using System.Threading;
using ThinkingAnalytics.TaException;
using ThinkingAnalytics.Wrapper;
using UnityEngine;

namespace ThinkingAnalytics
{
	[DisallowMultipleComponent]
	public class ThinkingAnalyticsAPI : MonoBehaviour, TaExceptionHandler
	{
		[Serializable]
		public struct Token
		{
			public string appid;

			public string serverUrl;

			public TAMode mode;

			public TATimeZone timeZone;

			public string timeZoneId;

			public Token(string appId, string serverUrl, TAMode mode = TAMode.NORMAL, TATimeZone timeZone = TATimeZone.Local, string timeZoneId = null)
			{
				appid = null;
				this.serverUrl = null;
				this.mode = TAMode.NORMAL;
				this.timeZone = TATimeZone.Local;
				this.timeZoneId = null;
			}

			public string getTimeZoneId()
			{
				return null;
			}
		}

		public enum TATimeZone
		{
			Local = 0,
			UTC = 1,
			Asia_Shanghai = 2,
			Asia_Tokyo = 3,
			America_Los_Angeles = 4,
			America_New_York = 5,
			Other = 100
		}

		public enum TAMode
		{
			NORMAL = 0,
			DEBUG = 1,
			DEBUG_ONLY = 2
		}

		public enum NetworkType
		{
			DEFAULT = 1,
			WIFI = 2,
			ALL = 3
		}

		[Header("Configuration")]
		[Tooltip("是否手动初始化SDK")]
		public bool startManually;

		[Tooltip("是否打开 Log")]
		public bool enableLog;

		[Tooltip("设置网络类型")]
		public NetworkType networkType;

		[Header("Project")]
		[Tooltip("项目相关配置, APP ID 会在项目申请时给出")]
		[HideInInspector]
		public Token[] tokens;

		public readonly string VERSION;

		private static ThinkingAnalyticsAPI taAPIInstance;

		private IDynamicSuperProperties dynamicSuperProperties;

		private Dictionary<string, object> autoTrackProperties;

		private static ThinkingAnalyticsAPI TA_instance;

		private static string default_appid;

		private static bool tracking_enabled;

		private static ReaderWriterLockSlim instance_lock;

		private static readonly Dictionary<string, ThinkingAnalyticsWrapper> sInstances;

		public static void Identify(string FIRSTId, string appId = "")
		{
		}

		public static string GetDistinctId(string appId = "")
		{
			return null;
		}

		public static void Login(string account, string appId = "")
		{
		}

		public static void Logout(string appId = "")
		{
		}

		public static void Flush(string appId = "")
		{
		}

		public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties = null, string appId = "")
		{
		}

		public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties, string appId = "")
		{
		}

		public void InvokeTaExceptionHandler(string eventName, Dictionary<string, object> properties)
		{
		}

		public static void Track(string eventName, string appId = "")
		{
		}

		public static void Track(string eventName, Dictionary<string, object> properties, string appId = "")
		{
		}

		public static void Track(string eventName, Dictionary<string, object> properties, DateTime date, string appId = "")
		{
		}

		public static void Track(ThinkingAnalyticsEvent analyticsEvent, string appId = "")
		{
		}

		public static void SetSuperProperties(Dictionary<string, object> superProperties, string appId = "")
		{
		}

		public static void UnsetSuperProperty(string property, string appId = "")
		{
		}

		public static Dictionary<string, object> GetSuperProperties(string appId = "")
		{
			return null;
		}

		public static void ClearSuperProperties(string appId = "")
		{
		}

		public static TDPresetProperties GetPresetProperties(string appId = "")
		{
			return null;
		}

		public static void TimeEvent(string eventName, string appId = "")
		{
		}

		public static void UserSet(Dictionary<string, object> properties, string appId = "")
		{
		}

		public static void UserSet(Dictionary<string, object> properties, DateTime dateTime, string appId = "")
		{
		}

		public static void UserUnset(string property, string appId = "")
		{
		}

		public static void UserUnset(List<string> properties, string appId = "")
		{
		}

		public static void UserUnset(List<string> properties, DateTime dateTime, string appId = "")
		{
		}

		public static void UserSetOnce(Dictionary<string, object> properties, string appId = "")
		{
		}

		public static void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appId = "")
		{
		}

		public static void UserAdd(string property, object value, string appId = "")
		{
		}

		public static void UserAdd(Dictionary<string, object> properties, string appId = "")
		{
		}

		public static void UserAdd(Dictionary<string, object> properties, DateTime dateTime, string appId = "")
		{
		}

		public static void UserAppend(Dictionary<string, object> properties, string appId = "")
		{
		}

		public static void UserAppend(Dictionary<string, object> properties, DateTime dateTime, string appId = "")
		{
		}

		public static void UserDelete(string appId = "")
		{
		}

		public static void UserDelete(DateTime dateTime, string appId = "")
		{
		}

		public static void SetNetworkType(NetworkType networkType, string appId = "")
		{
		}

		public static string GetDeviceId()
		{
			return null;
		}

		public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appId = "")
		{
		}

		public static void OptOutTracking(string appId = "")
		{
		}

		public static void OptOutTrackingAndDeleteUser(string appId = "")
		{
		}

		public static void OptInTracking(string appId = "")
		{
		}

		public static void EnableTracking(bool enabled, string appId = "")
		{
		}

		public static string CreateLightInstance(string appId = "")
		{
			return null;
		}

		public static void CalibrateTime(long timestamp)
		{
		}

		public static void CalibrateTimeWithNtp(string ntpServer)
		{
		}

		public static void setDefaultAppid(string appId)
		{
		}

		public static void StartThinkingAnalytics(string appId, string serverUrl)
		{
		}

		public static void StartThinkingAnalytics(Token token)
		{
		}

		public static void StartThinkingAnalytics(Token[] tokens = null)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private static ThinkingAnalyticsWrapper getInstance(string appid)
		{
			return null;
		}
	}
}
