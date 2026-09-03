using System.IO;

namespace GameProtocol
{
	public sealed class CRespOnestoreFirstReward : IProtocol
	{
		public uint m_nCoins;

		public uint m_nDiamonds;

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
