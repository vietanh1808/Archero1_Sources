namespace ThinkingSDK.PC.Config
{
	public class ThinkingSDKPublicConfig
	{
		private bool isPrintLog;

		private string version;

		private string name;

		private static readonly ThinkingSDKPublicConfig config;

		static ThinkingSDKPublicConfig()
		{
		}

		private static ThinkingSDKPublicConfig GetConfig()
		{
			return null;
		}

		public static void SetIsPrintLog(bool isPrint)
		{
		}

		public static bool IsPrintLog()
		{
			return false;
		}

		public static void SetVersion(string libVersion)
		{
		}

		public static void SetName(string libName)
		{
		}

		public static string Version()
		{
			return null;
		}

		public static string Name()
		{
			return null;
		}
	}
}
