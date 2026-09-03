using System.IO;

namespace GameProtocol
{
	public sealed class CRespHeroUpgrade : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nHeroId;

		public uint m_nTotalCoins;

		public ushort m_nLevel;

		public uint m_nPowerNum;

		public uint m_nHeroStar;

		public CEquipmentItem[] m_arrEquipInfo;

		public ushort m_nCoopLevel;

		public long m_nTotalCoinsInt64;

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
