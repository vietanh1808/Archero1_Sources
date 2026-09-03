using System.IO;

namespace GameProtocol
{
	public sealed class CRespDragonCompose : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong[] m_vecDeleteEquipRowIds;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
