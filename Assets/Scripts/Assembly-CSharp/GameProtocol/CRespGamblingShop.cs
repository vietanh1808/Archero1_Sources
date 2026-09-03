using System.IO;

namespace GameProtocol
{
	public sealed class CRespGamblingShop : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nBuyCnt;

		public string m_strJsonInfo;

		public uint m_nSeqNo;

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
