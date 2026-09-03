using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityCircleTreasure : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public uint m_nOpenGameLevel;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public ulong m_nRefreshTime;

		public uint m_nHammerItemId;

		public STActivityCircleTreasurePanel m_stPanel;

		public STActivityCircleTreasureTask m_stTask;

		public Dictionary<uint, STCommonQuickBuyData> m_mapQuickBuyData;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public ushort m_nGameLevel;

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
