using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityArtifactIdentifyAnniversary : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nDailyTime;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nEndTime;

		public uint m_nLayer;

		public uint m_nOpenGameLevel;

		public uint m_nRound;

		public uint m_nCurBoxGrade;

		public uint m_nCurInjectCount;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STCommonQuickBuyData m_stQuickBuy;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public STActivityArtifactIdentifyGift m_stGift;

		public STActivityArtifactIdentifyTask m_stTask;

		public STActivityArtifactIdentifyShop m_stShop;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
