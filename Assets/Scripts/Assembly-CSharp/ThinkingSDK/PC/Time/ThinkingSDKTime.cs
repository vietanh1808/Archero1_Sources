using System;

namespace ThinkingSDK.PC.Time
{
	public class ThinkingSDKTime : ThinkingSDKTimeInter
	{
		private TimeZoneInfo mTimeZone;

		private DateTime mDate;

		public ThinkingSDKTime(TimeZoneInfo timezone, DateTime date)
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
