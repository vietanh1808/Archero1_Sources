using System.IO;

namespace GameProtocol
{
	public sealed class CRespMailList : IProtocol
	{
		public const ushort MsgType = 5;

		public CMailInfo[] mailList;

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
