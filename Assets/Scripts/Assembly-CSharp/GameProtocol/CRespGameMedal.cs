using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameMedal : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string strMedal;

		public uint[] arrayEquipMedal;

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
