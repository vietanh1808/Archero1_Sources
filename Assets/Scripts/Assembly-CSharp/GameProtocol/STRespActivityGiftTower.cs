using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityGiftTower : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nTag;

		public ulong m_nStartTime;

		public ulong m_nGameEndTime;

		public ulong m_nRewardEndTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public uint m_nProgressValue;

		public uint m_nProgressRewardBits;

		public uint m_nRewardTowerLayer;

		public uint m_nTowerHeight;

		public uint m_nTowerFinishNum;

		public STActivityGiftTowerGridProtoData[][] m_vecGridDatas;

		public Dictionary<uint, ushort> m_mapInitItemNum;

		public STCommonQuickBuyData m_stQuickBuy;

		public STAutoDeleteActivityItem m_stAutoDeleteActivityItem;

		public STActivityGiftTowerGift m_stGift;

		public STActivityGiftTowerTask m_stTask;

		public STActivityGiftTowerShop m_stShop;

		public ulong m_nDailyTime;

		public uint m_nTowerGroup;

		public uint m_nTowerld;

		public ulong[] m_vecProgressRewardBits;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
