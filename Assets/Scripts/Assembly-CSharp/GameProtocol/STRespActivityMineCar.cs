using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityMineCar : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nTag;

		public ulong m_nOpenTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public ushort m_nOpenGameLevel;

		public ushort m_nLayerGameLevel;

		public ulong m_nRefreshTime;

		public STActivityMineCarPanel m_stPanel;

		public STActivityMineCarTask m_stTask;

		public STActivityMineCarShop m_stShop;

		public STActivityMineCarGift m_stGift;

		public STActivityMineCarAchievement m_stAchievement;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public uint m_nTicketItemId;

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
