using System.IO;

namespace GameProtocol
{
	public sealed class CRespDailyTaskInfo : IProtocol
	{
		public ulong m_nEndTime;

		public ushort m_nTaskPoint;

		public ulong m_nTaskReward;

		public CCommonRespMsg m_stRetMsg;

		public uint m_nTotalDiamonds;

		public uint m_nTotalCoins;

		public ushort m_nLife;

		public ushort m_nBattleRebornCount;

		public ushort m_nNormalDiamondItem;

		public ushort m_nLargeDiamondItem;

		public ushort m_nLevel;

		public uint m_nExperience;

		public CEquipmentItem[] m_arrEquipInfo;

		public ushort m_nTowerLife;

		public ushort m_nMixBoxItem;

		public ushort m_nDragonBoxItem;

		public ushort m_nRelicsBoxItem;

		public ushort m_nEquipSBoxItem;

		public STDailyTaskExtraRewardData[] m_vecExtraRewardData;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
