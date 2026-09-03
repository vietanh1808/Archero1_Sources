using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;

namespace Dxx.Net
{
	public class NetManager
	{
		private static bool _netconnect;

		private static bool _netcurrent;

		private static long _nettime;

		private static long _localtime;

		public const int TimeOut = 10;

		private static List<NetCacheOne> mTemps;

		private static NetCaches _NetCache;

		public static bool IsNetConnect => false;

		public static long NetTime => 0L;

		public static bool IsLogin => false;

		public static long LocalTime => 0L;

		public static float unitytime { get; private set; }

		public static int PingCount { get; private set; }

		public static NetCaches mNetCache => null;

		public static void SetNetTime(long time)
		{
		}

		public static string GetNetType()
		{
			return null;
		}

		public static void RefreshUnityTime()
		{
		}

		public static void StartPing()
		{
		}

		public static void UpdateNetConnect()
		{
		}

		public static void SendInternal<T1>(T1 packet, SendType sendtype, Action<NetResponse> callback) where T1 : CProtocolBase
		{
		}

		public static void SendInternal<T1>(T1 packet, SendType sendtype, int count, int time, Action<NetResponse> callback) where T1 : CProtocolBase
		{
		}

		public static void SendInternal(NetCacheOne senddata, Action<NetResponse> callback)
		{
		}

		public static CReqItemPacket GetGameOverPacket(CReqItemPacket.eItemType type, List<Drop_DropModel.DropData> list, bool inittransid)
		{
			return null;
		}

		public static CReqItemPacket GetItemPacket(List<Drop_DropModel.DropData> list, bool addequipmust = false, bool inittransid = true)
		{
			return null;
		}

		public static void CheckBattleRequest(CProtocolBase prototol, string log)
		{
		}

		private static void check(ulong serveruserid)
		{
		}

		private static bool CheckBattleNetCache(ref CReqItemPacket itemPack)
		{
			return false;
		}

		private static bool GetValidRewardList(CEquipmentItem[] equips, int maxEquip, int maxScroll, int maxStone, out CEquipmentItem[] limitEquips)
		{
			limitEquips = null;
			return false;
		}

		public static bool CheckCache(int sendcode)
		{
			return false;
		}
	}
}
