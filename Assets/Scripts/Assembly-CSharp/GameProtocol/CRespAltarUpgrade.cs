using System.IO;

namespace GameProtocol
{
	public sealed class CRespAltarUpgrade : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nEquipAltarLv;

		public uint m_nEquipAltarBreakId;

		public uint m_nEquipAltarProgress;

		public ushort m_nPrayCnt;

		public uint m_nCostDiamond;

		public ulong m_nPrayLastTime;

		public uint m_nEffectId;

		public ulong m_nPrayFreeTime;

		public uint m_nEffectValue;

		public uint m_nHeroAltarLv;

		public uint m_nHeroAltarBreakId;

		public uint m_nHeroAltarProgress;

		public ushort m_nPrayEquipRewardLen;

		public bool m_bIsOpenRelics;

		public uint m_nRelicsAltarLv;

		public uint m_nRelicsAltarBreakId;

		public uint m_nRelicsAltarProgress;

		public CRewardItem[] m_vecEquipRewardItems;

		public CRewardItem[] m_vecHeroRewardItems;

		public CRewardItem[] m_vecRelicsRewardItems;

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
