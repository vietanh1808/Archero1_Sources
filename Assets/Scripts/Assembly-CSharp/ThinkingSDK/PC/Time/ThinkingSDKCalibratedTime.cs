using System;

namespace ThinkingSDK.PC.Time
{
	public class ThinkingSDKCalibratedTime : ThinkingSDKTimeInter
	{
		private ThinkingSDKTimeCalibration mCalibratedTime;

		private long mSystemElapsedRealtime;

		private TimeZoneInfo mTimeZone;

		private DateTime mDate;

		public ThinkingSDKCalibratedTime(ThinkingSDKTimeCalibration calibrateTimeInter, TimeZoneInfo timeZoneInfo)
		{
		}

		public string GetTime()
		{
			return null;
		}

		public double GetZoneOffset()
		{
			return 0.0;
		}
	}
}
