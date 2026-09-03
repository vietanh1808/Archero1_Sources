using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityLattice : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nRequestType;

		public ushort m_nLayer;

		public uint m_nScore;

		public uint m_nRewardId;

		public uint[] m_vecChoices;

		public uint[] m_vecLattices;

		public ushort m_nLatticeIndex;

		public ushort m_nHitChoiceIndex;

		public uint[] m_vecOpenLattices;

		public CLatticeExchangeData[] m_vecExchangeData;

		public ushort m_nId;

		public short m_nCount;

		public ushort m_ntotalCount;

		public uint m_nGiftId;

		public string m_strGiftBuyCnt;

		public uint[] m_vecSuperChoices;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
