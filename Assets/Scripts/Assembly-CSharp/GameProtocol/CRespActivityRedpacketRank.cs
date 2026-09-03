using System.IO;

namespace GameProtocol
{
	public sealed class CRespActivityRedpacketRank : IProtocol
	{
		public short m_nStatusCode;

		public ushort m_nType;

		public CRedpacketRank[] m_arrayRank;

		public ulong m_nMyValue;

		public uint m_nMyRank;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
