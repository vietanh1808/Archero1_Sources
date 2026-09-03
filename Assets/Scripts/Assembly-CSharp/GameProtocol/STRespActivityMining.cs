using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityMining : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public uint m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nTaskEndTime;

		public ulong m_nGameEndTime;

		public ulong m_nRefreshTime;

		public STActivityMiningBlockMap m_stBlockMap;

		public STActivityMiningGift m_stGift;

		public STActivityMiningShop m_stShop;

		public STActivityMiningTask m_stTask;

		public STActivityMiningAchievement m_stAchievement;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
