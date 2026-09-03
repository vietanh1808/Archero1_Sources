using System.IO;

namespace GameProtocol
{
	public sealed class CRespLoginGift : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nResponseType;

		public long m_nNextReceiveTimestamp;

		public long m_nNowTimestamp;

		public ushort m_nRewardIndex;

		public string m_strRewardInfo;

		public CRewardItem[] m_vecRewardItem;

		public uint m_nTotalCoins;

		public int m_nTotalDiamonds;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItems;

		public ushort m_nLargeDiamondItems;

		public ushort m_nLife;

		public CEquipmentItem[] m_vecEquipmentInfo;

		public long m_nTotalCoinsInt64;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
