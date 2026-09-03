using System.IO;

namespace GameProtocol
{
	public sealed class CRespRunePolish : IProtocol
	{
		public short m_nStatusCode;

		public string m_strPolish;

		public string m_strPolishTemp;

		public uint m_nCoins;

		public uint m_nPolishMatNum;

		public uint m_nPolishCnt;

		public string m_strPolishAchieve;

		public long m_nCoinsInt64;

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
