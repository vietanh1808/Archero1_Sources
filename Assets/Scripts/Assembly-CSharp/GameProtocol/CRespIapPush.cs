using System.IO;

namespace GameProtocol
{
	public sealed class CRespIapPush : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CEquipmentItem[] m_arrEquipInfo;

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
