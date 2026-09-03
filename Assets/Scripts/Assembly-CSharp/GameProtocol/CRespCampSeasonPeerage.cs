using System.IO;

namespace GameProtocol
{
	public sealed class CRespCampSeasonPeerage : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nPeerage;

		public uint m_nPeerageExp;

		public ulong m_nRewardBits;

		public uint m_nMyRank;

		public CCampRank[] m_arrayRank;

		public ulong[] m_arrayLeaders;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
