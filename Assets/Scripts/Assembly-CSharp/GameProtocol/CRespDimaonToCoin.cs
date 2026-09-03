using System.IO;

namespace GameProtocol
{
	public sealed class CRespDimaonToCoin : IProtocol
	{
		public uint m_nCoins;

		public int m_nDiamonds;

		public ushort m_nAdCount;

		public ulong m_nFreeTimestamp;

		public long m_nCoinsInt64;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
