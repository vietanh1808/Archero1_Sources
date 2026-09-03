using System;
using UnityEngine;

namespace Guild.Hall
{
	public class GuildBaseMono : MonoBehaviour
	{
		public virtual void OnInit()
		{
		}

		public virtual void OnOpen()
		{
		}

		public virtual void OnClose()
		{
		}

		public virtual void OnLanguageChange()
		{
		}

		public static DateTime GetNextDay(int nextDay)
		{
			return default;
		}

		public static DateTime GetNextWeek()
		{
			return default;
		}

		private static void GetDateInts(ref int tyear, ref int tmonth, ref int tday, int tlastDay)
		{
		}

		public static DateTime GetNextMonth()
		{
			return default;
		}

		public static string GetNextDayTimeString()
		{
			return null;
		}

		public static string GetNextWeekTimeString()
		{
			return null;
		}

		public static string GetNextMonthTimeString()
		{
			return null;
		}

		public static string GetTimeInterval(DateTime nextday)
		{
			return null;
		}

		public static string GetTimeInterval(long secondUtcTicks)
		{
			return null;
		}

		public static string GetNetTimeInterval(long secondUtcTicks)
		{
			return null;
		}

		public static string GetDayTimeStep(DateTime frontTime, DateTime lastTime)
		{
			return null;
		}

		private static string GetTimeString(long second)
		{
			return null;
		}
	}
}
