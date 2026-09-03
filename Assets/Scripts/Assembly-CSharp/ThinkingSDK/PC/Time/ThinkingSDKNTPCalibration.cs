using System;

namespace ThinkingSDK.PC.Time
{
	public class ThinkingSDKNTPCalibration : ThinkingSDKTimeCalibration
	{
		public ThinkingSDKNTPCalibration(string ntpServer)
		{
		}

		private static double ConvertDateTimeInt(DateTime time)
		{
			return 0.0;
		}

		private static DateTime GetNetworkTime(string ntpServer)
		{
			return default;
		}

		private static uint SwapEndianness(ulong x)
		{
			return 0u;
		}
	}
}
