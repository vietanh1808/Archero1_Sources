using System.IO;

namespace GameProtocol
{
	public sealed class STShipBattleSeasonGiftConf
	{
		public uint m_nID;

		public ushort m_nType;

		public uint[] m_vecConditionId;

		public uint m_nPosition;

		public string m_strProductId;

		public uint[][] m_vecPrice;

		public uint m_nQuota;

		public uint[][] m_vecRewards;

		public uint m_nDiscount;

		public uint m_nTime;

		public void ReadFromStream(BinaryReader reader)
		{
		}
	}
}
