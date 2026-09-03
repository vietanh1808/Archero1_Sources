using System;
using UnityEngine;

namespace Habby.AssetExpress.Event
{
	public class NetworkListener
	{
		private const float PER_UDPATE_CYCLE = 1f;

		public static Action<NetworkReachability> OnNetworkReachabilityChanged;

		private static float _lastUpdateTime;

		public static NetworkReachability NetworkStatus { get; private set; }

		public static void Update()
		{
		}

		public static bool IsNetowrkAvaliable()
		{
			return false;
		}
	}
}
