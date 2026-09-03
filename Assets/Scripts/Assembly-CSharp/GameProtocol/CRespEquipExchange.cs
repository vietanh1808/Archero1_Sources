using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipExchange : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nCount;

		public ulong m_nStartTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
