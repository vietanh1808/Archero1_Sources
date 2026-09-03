using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ThinkingAnalytics.Utils
{
	public class TD_PropertiesChecker
	{
		private static readonly Regex keyPattern;

		public static bool IsNumeric(object obj)
		{
			return false;
		}

		public static bool IsString(object obj)
		{
			return false;
		}

		public static bool IsDictionary(object obj)
		{
			return false;
		}

		public static bool IsList(object obj)
		{
			return false;
		}

		public static bool CheckProperties<V>(Dictionary<string, V> properties)
		{
			return false;
		}

		public static bool CheckProperties(List<object> properties)
		{
			return false;
		}

		public static bool CheckProperties(List<string> properties)
		{
			return false;
		}

		public static bool CheckProperties(string properties)
		{
			return false;
		}

		public static bool CheckProperties(double properties)
		{
			return false;
		}

		public static bool CheckString(string eventName)
		{
			return false;
		}

		public static void MergeProperties(Dictionary<string, object> source, Dictionary<string, object> dest)
		{
		}
	}
}
