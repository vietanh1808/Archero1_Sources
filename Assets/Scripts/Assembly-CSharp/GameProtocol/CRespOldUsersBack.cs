using System.IO;

namespace GameProtocol
{
	public sealed class CRespOldUsersBack : IProtocol
	{
		public ushort m_nResponseType;

		public CCommonRespMsg m_stRetMsg;

		public CRewardItem[] m_vecRewardItem;

		public ushort m_nLossDays;

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
