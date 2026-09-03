using System;
using System.Collections.Generic;
using ThinkingSDK.PC.Config;
using ThinkingSDK.PC.DataModel;
using UnityEngine;

namespace ThinkingSDK.PC.Main
{
	public class ThinkingPCSDK
	{
		private static readonly Dictionary<string, ThinkingSDKInstance> Instances;

		private static string CurrentAppid;

		private ThinkingPCSDK()
		{
		}

		private static ThinkingSDKInstance GetInstance(string appid)
		{
			return null;
		}

		public static ThinkingSDKInstance CurrentInstance()
		{
			return null;
		}

		public static ThinkingSDKInstance Init(string appid, string server, ThinkingSDKConfig config = null, MonoBehaviour mono = null)
		{
			return null;
		}

		public static void Identifiy(string distinctID, string appid = "")
		{
		}

		public static string DistinctId(string appid = "")
		{
			return null;
		}

		public static void Login(string accountID, string appid = "")
		{
		}

		public static string AccountID(string appid = "")
		{
			return null;
		}

		public static void Logout(string appid = "")
		{
		}

		public static void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void Track(string eventName, string appid = "")
		{
		}

		public static void Track(string eventName, Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void Track(string eventName, Dictionary<string, object> properties, DateTime date, string appid = "")
		{
		}

		public static void Track(ThinkingSDKEventData analyticsEvent, string appid = "")
		{
		}

		public static void Flush(string appid = "")
		{
		}

		public static void SetSuperProperties(Dictionary<string, object> superProperties, string appid = "")
		{
		}

		public static void UnsetSuperProperty(string propertyKey, string appid = "")
		{
		}

		public static Dictionary<string, object> SuperProperties(string appid = "")
		{
			return null;
		}

		public static Dictionary<string, object> PresetProperties(string appid = "")
		{
			return null;
		}

		public static void ClearSuperProperties(string appid = "")
		{
		}

		public static void TimeEvent(string eventName, string appid = "")
		{
		}

		public static void UserSet(Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void UserSet(Dictionary<string, object> properties, DateTime dateTime, string appid = "")
		{
		}

		public static void UserUnset(string propertyKey, string appid = "")
		{
		}

		public static void UserUnset(string propertyKey, DateTime dateTime, string appid = "")
		{
		}

		public static void UserUnset(List<string> propertyKeys, string appid = "")
		{
		}

		public static void UserUnset(List<string> propertyKeys, DateTime dateTime, string appid = "")
		{
		}

		public static void UserSetOnce(Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void UserSetOnce(Dictionary<string, object> properties, DateTime dateTime, string appid = "")
		{
		}

		public static void UserAdd(Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void UserAdd(Dictionary<string, object> properties, DateTime dateTime, string appid = "")
		{
		}

		public static void UserAppend(Dictionary<string, object> properties, string appid = "")
		{
		}

		public static void UserAppend(Dictionary<string, object> properties, DateTime dateTime, string appid = "")
		{
		}

		public static void UserDelete(string appid = "")
		{
		}

		public static void UserDelete(DateTime dateTime, string appid = "")
		{
		}

		public static void SetDynamicSuperProperties(IDynamicSuperProperties dynamicSuperProperties, string appid = "")
		{
		}

		public static void OptTracking(bool optTracking, string appid = "")
		{
		}

		public static void EnableTracking(bool isEnable, string appid = "")
		{
		}

		public static void OptTrackingAndDeleteUser(string appid = "")
		{
		}

		public static ThinkingSDKInstance CreateLightInstance(string lightAppid)
		{
			return null;
		}

		public static void CalibrateTime(long timestamp)
		{
		}

		public static void CalibrateTimeWithNtp(string ntpServer)
		{
		}

		public static string GetDeviceId()
		{
			return null;
		}

		public static void EnableLog(bool isEnable)
		{
		}

		public static void SetLibName(string name)
		{
		}

		public static void SetLibVersion(string versionCode)
		{
		}

		public static string TimeString(DateTime dateTime, string appid = "")
		{
			return null;
		}
	}
}
