using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampBattlepass : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nBattlepassTag;

		public byte[] m_arrBattlepassMask;

		public bool m_bIsIAPBattlepass;

		public bool m_bIsIAPBattleBigpass;

		public uint m_nTotalCostLife;

		public CCampBPRewardConf[] m_arrTagInfo;

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
