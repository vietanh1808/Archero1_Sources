using System.Collections.Generic;

namespace Dxx.Net
{
	public class NetConfig
	{
		public const string HttpNetBattle = "https://archero-battle-net.habby.com";

		public const string HttpNetBattle_Test1 = "https://13.230.1.219:12080";

		public const string HttpNetBattle_Test = "https://47.102.14.135:12080";

		public const string HttpPath_formal = "https://game-archero-v1.archerosvc.com";

		public const string HttpPath_formalPre = "https://pre-game-archero-v1.archerosvc.com";

		public const string HttpPath_test = "http://test-archero.habby.com:80";

		public const string HttpPath_dev = "https://dev-game-archero-v1.archerosvc.com";

		public static Dictionary<int, string> mIPs;

		public const ushort ForceTimeOut = 1;

		public const ushort TryCallBackEquals = 2;

		public const ushort TryCallBackCommon = 3;

		public const ushort DATA_EXIST = 4;

		public const ushort TIPS_TYPE_ERROR = 5;

		public const ushort MainActivity_DataNull = 6;

		public const ushort MainActivity_ReponseNull = 7;

		public const ushort IAP_ResponseNull = 8;

		public static string HttpNetBattlePath => null;

		public static string HttpPath => null;

		public static bool IsTest => false;

		public static string HttpIAPPath => null;

		public static ushort NetVersion => 0;

		public static string GetPath(ushort sendcode, string ip)
		{
			return null;
		}

		public static bool isCooperationBattlePacket(ushort sendcode)
		{
			return false;
		}

		public static string GetIP(int random)
		{
			return null;
		}

		public static string RandomIP()
		{
			return null;
		}
	}
}
