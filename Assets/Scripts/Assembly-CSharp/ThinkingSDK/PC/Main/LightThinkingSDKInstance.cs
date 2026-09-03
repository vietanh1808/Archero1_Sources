using System.Collections.Generic;
using ThinkingSDK.PC.Config;
using UnityEngine;

namespace ThinkingSDK.PC.Main
{
	public class LightThinkingSDKInstance : ThinkingSDKInstance
	{
		public LightThinkingSDKInstance(string appid, string server, ThinkingSDKConfig config, MonoBehaviour mono = null)
			: base(null, null)
		{
		}

		public override void Identifiy(string distinctID)
		{
		}

		public override string DistinctId()
		{
			return null;
		}

		public override void Login(string accountID)
		{
		}

		public override string AccountID()
		{
			return null;
		}

		public override void Logout()
		{
		}

		public override void SetSuperProperties(Dictionary<string, object> superProperties)
		{
		}

		public override void UnsetSuperProperty(string propertyKey)
		{
		}

		public override Dictionary<string, object> SuperProperties()
		{
			return null;
		}

		public override void ClearSuperProperties()
		{
		}

		public override void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		public override void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<string, object> properties)
		{
		}

		public override void Flush()
		{
		}
	}
}
