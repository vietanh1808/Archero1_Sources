using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityMagicCrystal : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ushort m_nTag;

		public ushort m_nTopic;

		public uint m_nItemId;

		public ushort m_nSpend;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public ulong m_nExchangeTime;

		public string m_strConfigs;

		public uint m_nTotalCount;

		public ushort m_nBigRewardRound;

		public uint m_nRoundId;

		public uint[] m_vecBigRound;

		public STActivityMagicTask[] vecTaskData;

		public string m_strGiftBuyCnt;

		public STMagicExchangeData[] vecExchangeData;

		public uint m_nClassId;

		public uint m_nLastExchangeCount;

		public string m_strMonsterNum;

		public uint m_nEggPieceId;

		public uint[] m_vecDelItemId;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STCommonQuickBuyData m_stQuickBuy;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
