using System.IO;

namespace GameProtocol
{
	public sealed class CRespIAPDiscountInfo : IProtocol
	{
		public string m_strJsonInfo;

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
