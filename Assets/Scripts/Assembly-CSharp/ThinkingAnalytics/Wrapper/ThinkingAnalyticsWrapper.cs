using System;
using System.Collections.Generic;
using ThinkingSDK.PC.Main;
using UnityEngine;

namespace ThinkingAnalytics.Wrapper
{
	public class ThinkingAnalyticsWrapper : ThinkingSDK.PC.Main.IDynamicSuperProperties
	{
		public interface IDynamicSuperPropertiesTrackerListener
		{
			string getDynamicSuperPropertiesString();
		}

		private class ListenerAdapter : AndroidJavaProxy
		{
			public ListenerAdapter()
				: base((string)null)
			{
			}

			public string getDynamicSuperPropertiesString()
			{
				return null;
			}
		}

		private static ThinkingAnalyticsWrapper wrapper;

		private static readonly string JSON_CLASS;

		private static readonly AndroidJavaClass sdkClass;

		private static readonly AndroidJavaClass configClass;

		private AndroidJavaObject instance;

		public MonoBehaviour taMono;

		public readonly ThinkingAnalyticsAPI.Token token;

		private IDynamicSuperProperties dynamicSuperProperties;

		private static System.Random rnd;

		private static AndroidJavaObject getJSONObject(string dataString)
		{
			return null;
		}

		private string getTimeString(DateTime dateTime)
		{
			return null;
		}

		private static void enable_log(bool enableLog)
		{
		}

		private static void setVersionInfo(string libName, string version)
		{
		}

		private void init()
		{
		}

		private void flush()
		{
		}

		private AndroidJavaObject getDate(DateTime dateTime)
		{
			return null;
		}

		private void track(string eventName, string properties, DateTime dateTime)
		{
		}

		private void track(ThinkingAnalyticsEvent taEvent)
		{
		}

		private void track(string eventName, string properties)
		{
		}

		private void setSuperProperties(string superProperties)
		{
		}

		private void unsetSuperProperty(string superPropertyName)
		{
		}

		private void clearSuperProperty()
		{
		}

		private Dictionary<string, object> getSuperProperties()
		{
			return null;
		}

		private Dictionary<string, object> getPresetProperties()
		{
			return null;
		}

		private void timeEvent(string eventName)
		{
		}

		private void identify(string uniqueId)
		{
		}

		private string getDistinctId()
		{
			return null;
		}

		private void login(string uniqueId)
		{
		}

		private void userSetOnce(string properties)
		{
		}

		private void userSetOnce(string properties, DateTime dateTime)
		{
		}

		private void userSet(string properties)
		{
		}

		private void userSet(string properties, DateTime dateTime)
		{
		}

		private void userUnset(List<string> properties)
		{
		}

		private void userUnset(List<string> properties, DateTime dateTime)
		{
		}

		private void userAdd(string properties)
		{
		}

		private void userAdd(string properties, DateTime dateTime)
		{
		}

		private void userAppend(string properties)
		{
		}

		private void userAppend(string properties, DateTime dateTime)
		{
		}

		private void userDelete()
		{
		}

		private void userDelete(DateTime dateTime)
		{
		}

		private void logout()
		{
		}

		private string getDeviceId()
		{
			return null;
		}

		public void setDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties)
		{
		}

		private void setNetworkType(ThinkingAnalyticsAPI.NetworkType networkType)
		{
		}

		private void enableAutoTrack(AUTO_TRACK_EVENTS events, string properties)
		{
		}

		private void setAutoTrackProperties(AUTO_TRACK_EVENTS events, string properties)
		{
		}

		private void optOutTracking()
		{
		}

		private void optOutTrackingAndDeleteUser()
		{
		}

		private void optInTracking()
		{
		}

		private void enableTracking(bool enabled)
		{
		}

		private void setInstance(AndroidJavaObject anotherInstance)
		{
		}

		private ThinkingAnalyticsWrapper createLightInstance(ThinkingAnalyticsAPI.Token delegateToken)
		{
			return null;
		}

		private static void calibrateTime(long timestamp)
		{
		}

		private static void calibrateTimeWithNtp(string ntpServer)
		{
		}

		private string serilize<T>(Dictionary<string, T> data)
		{
			return null;
		}

		public Dictionary<string, object> GetDynamicSuperProperties()
		{
			return null;
		}

		public ThinkingAnalyticsWrapper(ThinkingAnalyticsAPI.Token token, MonoBehaviour mono, bool initRequired = true)
		{
		}

		public static void EnableLog(bool enableLog)
		{
		}

		public static void SetVersionInfo(string version)
		{
		}

		public void Identify(string uniqueId)
		{
		}

		public string GetDistinctId()
		{
			return null;
		}

		public void Login(string accountId)
		{
		}

		public void Logout()
		{
		}

		public void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		public void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		private string getFinalEventProperties(Dictionary<string, object> properties)
		{
			return null;
		}

		public void Track(string eventName, Dictionary<string, object> properties)
		{
		}

		public void Track(string eventName, Dictionary<string, object> properties, DateTime datetime)
		{
		}

		public void Track(ThinkingAnalyticsEvent taEvent)
		{
		}

		public void SetSuperProperties(Dictionary<string, object> superProperties)
		{
		}

		public void UnsetSuperProperty(string superPropertyName)
		{
		}

		public void ClearSuperProperty()
		{
		}

		public void TimeEvent(string eventName)
		{
		}

		public Dictionary<string, object> GetSuperProperties()
		{
			return null;
		}

		public Dictionary<string, object> GetPresetProperties()
		{
			return null;
		}

		public void UserSet(Dictionary<string, object> properties)
		{
		}

		public void UserSet(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserSetOnce(Dictionary<string, object> properties)
		{
		}

		public void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserUnset(List<string> properties)
		{
		}

		public void UserUnset(List<string> properties, DateTime dateTime)
		{
		}

		public void UserAdd(Dictionary<string, object> properties)
		{
		}

		public void UserAdd(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserAppend(Dictionary<string, object> properties)
		{
		}

		public void UserAppend(Dictionary<string, object> properties, DateTime dateTime)
		{
		}

		public void UserDelete()
		{
		}

		public void UserDelete(DateTime dateTime)
		{
		}

		public void Flush()
		{
		}

		public void SetNetworkType(ThinkingAnalyticsAPI.NetworkType networkType)
		{
		}

		public string GetDeviceId()
		{
			return null;
		}

		public void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties)
		{
		}

		public void OptOutTracking()
		{
		}

		public void OptOutTrackingAndDeleteUser()
		{
		}

		public void OptInTracking()
		{
		}

		public void EnableTracking(bool enabled)
		{
		}

		public ThinkingAnalyticsWrapper CreateLightInstance()
		{
			return null;
		}

		internal string GetAppId()
		{
			return null;
		}

		public static void CalibrateTime(long timestamp)
		{
		}

		public static void CalibrateTimeWithNtp(string ntpServer)
		{
		}
	}
}
